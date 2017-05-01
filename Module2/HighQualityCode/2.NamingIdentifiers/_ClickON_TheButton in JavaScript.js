function clickOnTheButton(event,arguments) {
  var myWindow = window,
      browser = myWindow.navigator.appCodeName,
      ISM=browser=="Mozilla";
  if(ISM) {
    alert("Yes");
  } else {
    alert("No");
  }
}