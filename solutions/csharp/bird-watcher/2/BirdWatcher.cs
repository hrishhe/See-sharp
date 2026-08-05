class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int [] birdsLastweek = { 0, 2, 5, 3, 7, 8, 4 };
        return birdsLastweek;
    }

    public int Today()
    {
        int last = birdsPerDay.Length-1;
        return birdsPerDay[last]; 
    }

    public void IncrementTodaysCount()
    {
        int last = birdsPerDay.Length-1;
         birdsPerDay[last]= birdsPerDay[last]+1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int birds in birdsPerDay)
        {
            if (birds == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        for(int i=0;i<numberOfDays;i++)
        {
            count += birdsPerDay[i];
        }
        return count;
    }

    public int BusyDays()
    {
        int count=0;
        foreach (int birds in birdsPerDay)
        {
            
            if (birds >= 5)
            {
                count++;
                
            }
            
        }
        return count;
    }
}
