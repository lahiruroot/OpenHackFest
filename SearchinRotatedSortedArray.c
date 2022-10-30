int search(int* num, int numSize, int target) {
	int low = 0, high = numSize - 1;
	while (low < high) {
		int i = (low + high) >> 1;
		if (target > num[high])
			if (num[i] < target && num[i] > num[high]) low = i + 1;
			else high = i;
		else
			if (num[i] >= target && num[i] <= num[high]) high = i;
			else low = i + 1;
	}
	return num[low] == target ? low : -1;
}