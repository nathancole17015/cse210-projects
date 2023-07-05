List <Activity> _activities = new List<Activity>();


Running _run = new Running("03 Nov 2022", "Running",30,10);

Swimming _swim = new Swimming("20 Aug 2021","Swimming",40, 50);

Cycling _cycling = new Cycling("14 May 2023", "Cycling",40,16);

_activities.Add(_cycling);
_activities.Add(_run);
_activities.Add(_swim);



foreach (Activity activity in _activities){
        activity.GetSummary();
        Console.WriteLine();
}


