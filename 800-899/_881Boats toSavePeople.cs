namespace LeetCode._800_899;

public class _881Boats_toSavePeople
{
    public int NumRescueBoats(int[] people, int limit)
    {
        Array.Sort(people);
        int count = 0;
        int left = 0, right = people.Length - 1;
        while ( left <= right)
        {
            count++;
            if (left != right && people[left] + people[right] <= limit)
                left++;
            right--;

        }
        return count;
    }
}