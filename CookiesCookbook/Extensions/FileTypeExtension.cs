using System;

namespace CookiesCookbook.Extensions;

public static class FileTypeExtension
{
    public static string GetFileName(this FileType fileType, string fileName)
    {
        var extension = fileType == FileType.Json ? "json" : "txt";
        return $"{fileName}.{extension}";
    }
}
