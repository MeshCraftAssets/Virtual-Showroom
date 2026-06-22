mergeInto(LibraryManager.library, {
    OpenURLSameWindow: function(url) {
        window.location.href = UTF8ToString(url);
    }
});