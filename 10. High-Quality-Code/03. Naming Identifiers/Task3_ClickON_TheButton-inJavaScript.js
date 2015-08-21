function onButtonClick() {
    var currentWindow = window,
        currentBrowser = currentWindow.navigator.appCodeName,
        isCurrentBrowserMozilla = currentBrowser == "Mozilla";
    if (isCurrentBrowserMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}