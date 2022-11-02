namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int input) {
            string sentence = "";
            if (input % 3 == 0) {
                sentence = sentence + "Foo";
            }
            if (input % 5 == 0) {
                sentence = sentence + "Bar";
            }
            if (input % 7 == 0) {
                sentence = sentence + "Qix";
            }
            return sentence;
        }
    }
}