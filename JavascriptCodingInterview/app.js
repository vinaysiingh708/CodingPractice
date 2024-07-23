
// 1. Find LongestWord in javascript
function findLongestWord(sentence) {

    const words = sentence.split(" ");

    let longestword = "";

    for (let word of words) {

        if (word.length > longestword.length) {
            longestword = word;
        }
    }
    return longestword;
}

console.log(findLongestWord("I love coding in javascript"));

//2.