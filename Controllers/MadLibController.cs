//Jessie Lamzon
//10/25/22
//Mad Lib End Point
//
//Peer Review:Kent Tupas The program work like it intends to. There was no errors at all. 



using Microsoft.AspNetCore.Mvc;

namespace lammzonJ_MadLibEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
    [HttpGet]
    [Route("MadLib/{celeb}/{animal}/{personName}/{profession}/{from}/{bodyPart}/{verb}/{plant}")]
    

    //copy and paste this pre-made list or copy and edit your own
    //MadLib/MadLib/Britney/monkey/Alfred/Geologist/Lathrop, CA/Elbow/Rolled/Hibiscus
    //MadLib/MadLib/celeb/animal/person's name/occupation/where from/body part/action verb/any plant

    //string concatination was used and \n to put each sentence on the next line
    public string MadLib(string celeb, string animal, string personName, string profession, string from, string bodyPart, string verb, string plant)
    {
        return $"I woke up this morning and saw {celeb}. \nI said hey! What are you doing with my {animal}! \n{celeb} looked at me and said who are you?! \nI said I'm {personName} and im a {profession} from {from}. \n{celeb} touched my {bodyPart} and yelled, You are in my house! \nRealizing i was in {celeb}'s house, I {verb} out of bed and grabbed my {plant} plant. \nI then woke up again.....whew, it was just a dream.";
    }
}
