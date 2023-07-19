using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunLengthEncoding;

namespace RunLengthEncoding.Tests
{
    public class RunLengthEncodingTest
    {
        [Fact]
        public void Run_length_encode_a_string_empty_string()
        {
            Assert.Equal("", LengthEncoding.Encode(""));
        }
        [Fact]
        public void Run_length_encode_a_string_single_characters_only_are_encoded_without_count()
        {
            Assert.Equal("XYZ", LengthEncoding.Encode("XYZ"));
        }
        [Fact]
        public void Run_length_encode_a_string_string_with_no_single_characters()
        {
            Assert.Equal("2A3B4C", LengthEncoding.Encode("AABBBCCCC"));
        }
        [Fact]
        public void Run_length_encode_a_string_single_characters_mixed_with_repeated_characters()
        {
            Assert.Equal("12WB12W3B24WB", LengthEncoding.Encode("WWWWWWWWWWWWBWWWWWWWWWWWWBBBWWWWWWWWWWWWWWWWWWWWWWWWB"));
        }
        [Fact]
        public void Run_length_encode_a_string_multiple_whitespace_mixed_in_string()
        {
            Assert.Equal("2 hs2q q2w2 ", LengthEncoding.Encode("  hsqq qww  "));
        }
        [Fact]
        public void Run_length_encode_a_string_lowercase_characters()
        {
            Assert.Equal("2a3b4c", LengthEncoding.Encode("aabbbcccc"));
        }
        [Fact]
        public void Run_length_decode_a_string_empty_string()
        {
            Assert.Equal("", LengthEncoding.Decode(""));
        }
        [Fact]
        public void Run_length_decode_a_string_single_characters_only()
        {
            Assert.Equal("XYZ", LengthEncoding.Decode("XYZ"));
        }
        [Fact]
        public void Run_length_decode_a_string_string_with_no_single_characters()
        {
            Assert.Equal("AABBBCCCC", LengthEncoding.Decode("2A3B4C"));
        }
        [Fact]
        public void Run_length_decode_a_string_single_characters_with_repeated_characters()
        {
            Assert.Equal("WWWWWWWWWWWWBWWWWWWWWWWWWBBBWWWWWWWWWWWWWWWWWWWWWWWWB", LengthEncoding.Decode("12WB12W3B24WB"));
        }
        [Fact]
        public void Run_length_decode_a_string_multiple_whitespace_mixed_in_string()
        {
            Assert.Equal("  hsqq qww  ", LengthEncoding.Decode("2 hs2q q2w2 "));
        }
        [Fact]
        public void Run_length_decode_a_string_lowercase_string()
        {
            Assert.Equal("aabbbcccc", LengthEncoding.Decode("2a3b4c"));
        }
        [Fact]
        public void Encode_and_then_decode_encode_followed_by_decode_gives_original_string()
        {
            Assert.Equal("zzz ZZ  zZ", LengthEncoding.Decode(LengthEncoding.Encode("zzz ZZ  zZ")));
        }

    }
}
