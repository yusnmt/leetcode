# How to think

## Substring / Subsequence Problem — Quick Solution Checklist

## 0. Word Check

| Keyword | Meaning | Typical Approach |
|------|--------|------------------|
| **Substring** | Continuous | Sliding Window / Two Pointers |
| **Subsequence** | Not necessarily continuous | DP / Greedy |

---

## 1. If the problem says **"Substring"**

### ✅ Step 1: Is it asking for **longest / max / min / count**?
👉 **Sliding Window / Two Pointers**

Typical phrases:
- longest substring
- without repeating characters
- at most / at least k
- contains all characters

Examples:
- Longest Substring Without Repeating Characters
- Longest Repeating Character Replacement
- Minimum Window Substring

---

### ✅ Step 2: Is the window size **fixed (k)**?
👉 **Fixed-Length Sliding Window**

Examples:
- Maximum sum of subarray of size k
- Find all anagrams in a string

---

### ✅ Step 3: Is it about **palindrome**?
👉 **Center Expansion** or **DP**

- Count palindromic substrings → Center Expansion
- Longest palindromic substring → Center Expansion / DP

---

### ✅ Step 4: Does it involve **two strings**?
👉 **DP (Longest Common Substring)**

```text
dp[i][j] = length of common substring ending at s1[i-1], s2[j-1]
```

## 2. If the problem says **"Subsequence"**

### ✅ Step 1: How many sequences are involved?

#### ▸ Single sequence
👉 **Dynamic Programming** or **Greedy**

Typical problems:
- Longest Increasing Subsequence (LIS)
- Longest Decreasing Subsequence
- Variants of increasing / decreasing subsequences

#### ▸ Two sequences
👉 **2D Dynamic Programming**

Typical problems:
- Longest Common Subsequence (LCS)
- Edit Distance (similar DP structure)

---

### ✅ Step 2: Is it asking for the **longest / maximum length**?

👉 **Dynamic Programming**

Typical DP definition:

- `dp[i]` = length of the longest subsequence ending at index `i`

Typical transition:

- For all `j < i`, if `nums[j] < nums[i]`, then  
  `dp[i] = max(dp[i], dp[j] + 1)`

---

### ✅ Step 3: Is it an **increasing / decreasing** subsequence?

#### ▸ Yes
👉 **DP** or **Greedy + Binary Search**

Approach options:
- DP (clear and intuitive): `O(n^2)`
- Greedy + Binary Search (optimized): `O(n log n)`

Greedy intuition:
- Maintain an array `tails[]`
- `tails[len]` = the smallest possible tail value of an increasing subsequence of length `len + 1`

---

### ✅ Step 4: Is the **actual subsequence** required?

#### ▸ Only the length is required
👉 **Greedy + Binary Search** (if applicable)

#### ▸ The sequence itself is required
👉 **Dynamic Programming + Path Reconstruction**

Reconstruction idea:
- Store the previous index for each `dp[i]`
- Backtrack from the index with the maximum `dp[i]`

---

### ✅ Step 5: Is the problem about **counting subsequences**?

👉 **Dynamic Programming**

Typical DP forms:
- `dp[i]` = number of valid subsequences ending at index `i`

or (two sequences):
- `dp[i][j]` = number of subsequences using `s1[0..i-1]` and `s2[0..j-1]`

---

### ❌ When NOT to use Subsequence DP

If the problem requires:
- Continuous range
- Window-based conditions

👉 It is a **substring** problem, not a subsequence problem.

---



