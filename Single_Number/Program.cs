using Single_Number;

var nums1 = new[] { 2, 2, 1 };
var nums2 = new[] { 4, 1, 2, 1, 2 };
var nums3 = new[] { 1 };
var nums4 = new[] { 1, 1, 1 };
var nums5 = new[] { 13, 13, 0, 11, 0 };

Console.WriteLine($"Input: nums = [2,2,1]\nOutput: {SingleNumberFinder.FindSingleNumber(nums1)}");
Console.WriteLine($"Input: nums = [4,1,2,1,2]\nOutput: {SingleNumberFinder.FindSingleNumber(nums2)}");
Console.WriteLine($"Input: nums = [1]\nOutput: {SingleNumberFinder.FindSingleNumber(nums3)}");
Console.WriteLine($"Input: nums = [1,1,1]\nOutput: {SingleNumberFinder.FindSingleNumber(nums4)}");
Console.WriteLine($"Input: nums = [13,13,0,11,0]\nOutput: {SingleNumberFinder.FindSingleNumber(nums5)}");