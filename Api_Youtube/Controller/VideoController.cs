﻿using Api_Youtube.Dto;
using Api_Youtube.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api_Youtube.Controller;

[Route("api/videos")]
[ApiController]
public class VideoController : BaseController
{
    private readonly VideoService _videoService;

    public VideoController(VideoService videoService)
    {
        _videoService = videoService;
    }

    [Authorize]
    [HttpPost("upload-video")]
    public async Task<IActionResult> UploadVideo([FromForm] UploadVideoDto request)
    {
        var userId = GetUserIdFromClaims();

        if (userId == 0)
        {
            return Unauthorized(new { message = "User not authenticated" });
        }

        var result = await _videoService.UploadVideoAsync(userId, request);

        if (result)
            return Ok(new { message = "Video uploaded successfully." });
        else
            return BadRequest(new { message = "Failed to upload video." });
    }

    [HttpGet("public-feed")]
    public async Task<IActionResult> GetPublicVideos()
    {
        var videos = await _videoService.GetPublicVideosAsync();
        return Ok(videos);
    }

    [Authorize]
    [HttpGet("user/{userId}")]
    public async Task<IActionResult> GetUserVideos(int userId)
    {
        var currentUserId = GetUserIdFromClaims();
        var isLoggedIn = currentUserId == userId;

        var videos = await _videoService.GetUserVideosAsync(userId, isLoggedIn);
        return Ok(videos);
    }

    [Authorize]
    [HttpPut("{videoId}")]
    public async Task<IActionResult> UpdateVideo(int videoId, [FromBody] UpdateVideoDto request)
    {
        var userId = GetUserIdFromClaims();
        var result = await _videoService.UpdateVideoAsync(videoId, userId, request);

        if (result)
            return Ok(new { message = "Video updated successfully." });
        else
            return BadRequest(new { message = "Failed to update video." });
    }

    [Authorize]
    [HttpDelete("{videoId}")]
    public async Task<IActionResult> DeleteVideo(int videoId)
    {
        var userId = GetUserIdFromClaims();
        var result = await _videoService.DeleteVideoAsync(videoId, userId);

        if (result)
            return Ok(new { message = "Video deleted successfully." });
        else
            return BadRequest(new { message = "Failed to delete video." });
    }
}