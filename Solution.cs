public class Solution {
    public string LongestPalindrome(string s) {
        //l = window length
        //i = index through number of windows
        var sarr = s.ToCharArray();
        for (int l = s.Length; l >= 0; l--) {
            for (int i = 0; i < s.Length - l + 1; i++) {
                if (CheckForPalindrome(sarr, i, l)) {
                    return s.Substring(i, l);
                }
            }
        }
        return string.Empty;
    }

    public bool CheckForPalindrome(char[] sarr, int index, int length) {
        for (int i = 0; i < length; i++) {
            if (sarr[index + i] != sarr[index + length - 1 - i])
                return false;
        }
        return true;
    }
}