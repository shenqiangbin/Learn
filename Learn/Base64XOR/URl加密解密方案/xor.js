function XOR(strLeft, strRight) {
    var str = "";
    var i;

    for (i = 0; i < strLeft.length; i++) {
        var index = i % strRight.length;
        str += String.fromCharCode(strLeft.charCodeAt(i) ^ strRight.charCodeAt(index));
    }
    return str;
}