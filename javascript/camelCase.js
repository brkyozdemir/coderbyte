function CamelCase(str) { 

  if(str == "")
    return "";

  var tempStr;
  str = str.toLowerCase();
  tempStr = str.split(/[-_*%]| /);
  var camelCase = tempStr[0];
  for(var i = 1;i<tempStr.length; i++){
    camelCase += opsCC(tempStr[i]);
  }
  // code goes here  
  return camelCase; 

}

function opsCC(str){
  return str[0].toUpperCase()+str.slice(1);
}
