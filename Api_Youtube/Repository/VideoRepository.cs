﻿using Api_Youtube.Model;

namespace Api_Youtube.Repository;

public interface VideoRepository
{
    Task<bool> CreateAsync(Video video);
    Task<List<Video>> GetPublicVideosAsync();
    Task<List<Video>> GetUserVideosAsync(int userId);
    Task<Video?> GetVideoByIdAsync(int videoId);
    Task<bool> DeleteAsync(Video video);
    Task<bool> SaveChangesAsync();
    Task<List<Video>> SearchVideosAsync(string keyword);
}