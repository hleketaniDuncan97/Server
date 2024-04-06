namespace stackup_vsc_setup.Model
{
public class Questions{

[Key]
public int QuestionId{get;set;} 

public int UserId{get;set;} 
public string Title{get;set;} 
public string Body{get;set;} 
public DateTime CreateAt{get;set;} 

 }

}


