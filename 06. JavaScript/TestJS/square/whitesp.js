var whitespace = /\x20\\t\\r\\n\\f/g;


// removes empty entries from string array
var str = 'djdjd \r  	  jskdkfk  \n   dfdsalkjd  sdlfnsd kksldkf  ';
var strArr = str.split(/\s+/g); //str.trim().split(/ +/g);
console.log(strArr);
strArr = strArr.filter(function(item) {
    return item;
});
console.log(strArr);