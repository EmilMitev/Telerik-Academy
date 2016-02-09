function OccurrencesOfWord(text, word, caseSensitive) {
    var index,
        counter = 0;
    if (!caseSensitive) {
        text = text.toLowerCase();
        word = word.toLowerCase();
    }
    index = text.indexOf(word);
    if (index !== -1) {
        while (index !== -1) {
            counter += 1;
            index = text.indexOf(word, index + 1);
        }
    }
    return counter;
}

var txt = 'Lorem ipsum dOlor sit amet'; //, consectetur adipiscing elit. Curabitur vitae imperdiet est. Quisque consectetur ultricies arcu vel interdum. Quisque diam est, elementum quis bibendum eget, volutpat vitae lectus. Mauris sit amet dolor ex. Morbi ac aliquet lorem. Quisque eu urna quis ante sagittis elementum ac nec magna. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Ut sit amet sem sit amet purus vulputate gravida varius ut est. Pellentesque dapibus ipsum ex. In sagittis maximus nisl, nec laoreet nulla tempus et. Aenean pellentesque dolor id nulla bibendum sodales non eget lorem. Phasellus lobortis consectetur ultrices. Sed.';

console.log(OccurrencesOfWord(txt, 'o'));
console.log(OccurrencesOfWord(txt, 'o', true));
