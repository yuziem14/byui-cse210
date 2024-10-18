public class Scripture {
    private Reference _reference;
    private List<Word> _words = [];
    
    public Scripture(Reference reference, string text) {
        _reference = reference;
        _words = InitializeWords(text);
    }

    public void HideRandomWords(int numberToHide) {
        int counter = 0;
        while(counter < numberToHide) {
            int randomIndex = new Random().Next(0, _words.Count());
            Word word = _words.ElementAt(randomIndex);

            if(!word.IsHidden()) {
                word.Hide();
                counter++;
            }

            if(IsCompletelyHidden()) {
                counter = numberToHide;
            }
        }
    }

    public string GetDisplayText() {
        string text = String.Join(" ", _words.Select(w => w.GetDisplayText()).ToArray());
        return $"{_reference.GetDisplayText()} {text}";
    }

    public bool IsCompletelyHidden() {
        return _words.All(w => w.IsHidden());
    }

    private List<Word> InitializeWords(string text) {
        List<Word> words = text
            .Split(" ")
            .Select(w => new Word(w)).ToList();
        return words;
    }
}