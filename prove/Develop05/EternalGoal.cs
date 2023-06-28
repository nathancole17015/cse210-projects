public class EternalGoals:Goals{
    private string _type = "EternalGoal";
    private string _name;
    private string _description;
    private int _points;
    
    public EternalGoals(){

}
 
  public override string GetGoal()
    {
        return $"{_type},{base.GetGoal()}";
    }
  
    public override void RecordEvents(List<Goals> _goals,int input){
  
       
       for (int i = 0; i < _goals.Count; i++){
       
                var goal = _goals[i];
            if (i + 1 == input){
                IsComplete(goal);
              
            

        
         }
         
         

    }
   
    
}
}
