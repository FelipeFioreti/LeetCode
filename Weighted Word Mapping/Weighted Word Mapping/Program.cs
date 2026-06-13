Console.WriteLine(MapWordWeights(["abcd","def","xyz"], [5,3,12,14,1,2,3,2,10,6,6,9,7,8,7,10,8,9,6,9,9,8,3,7,7,2]));

string MapWordWeights(string[] words, int[] weights) {
        string res = "";
        int sum = 0;
        foreach(var word in words){
            foreach(var letter in word){
                sum += weights[letter - 'a'];
            }
            res += (char)((int)'z' - (sum % 26));
            sum = 0;
        }

        return res;
}