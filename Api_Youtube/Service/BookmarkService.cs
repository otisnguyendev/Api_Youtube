using Api_Youtube.Dto;

namespace Api_Youtube.Service;

public interface BookmarkService
{
    Task<List<BookmarkDto>> GetUserBookmarksAsync(int userId);
    Task<BookmarkDto> AddBookmarkAsync(int userId, int videoId);
}