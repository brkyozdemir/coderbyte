function PalindromicSubstring(str) { 

  longestP = "";
  maxLen = 0;
  for(var i = 0;i<str.length; i++){
    var subS = str.substr(i,str.length);
    // console.log(subS);
    for(var j = subS.length;j>=0;j--){
      var subOfSub = subS.substr(0,j);
      // console.log(subOfSub);
      if(subOfSub.length <= 1)
        continue;
      if(isPalindrome(subOfSub) && subOfSub.length > maxLen){
        maxLen = subOfSub.length;
        longestP = subOfSub;
      }
      if(longestP.length <= 2)
        longestP = "none";
    }
  }
  // code goes here  
  return longestP; 

}

function isPalindrome(str){
  var temp = str.split('').reverse().join('');
  return str === temp;
}
