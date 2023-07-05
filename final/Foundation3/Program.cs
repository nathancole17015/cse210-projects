        Address _outdoorGatheringAdd = new Address("123 Oak Street", "Anytown" ,"CA", "USA",90210 );
OutdoorGatherings _outdoorGathering = new OutdoorGatherings("Outdoor Gathering","Summer Carnival","The Summer Carnival is a lively and thrilling event filled with rides, games, delicious food, and live entertainment, \ncreating a joyous atmosphere for people of all ages to enjoy.","June 15, 2023", "7:30pm","Sunny",_outdoorGatheringAdd);
 
 Address _lectureAdd = new Address("456 Elm Street", "Newton", "MA","USA",02458);
Lectures _lectures = new Lectures("Lecture","The Power of Positive Thinking: Unlocking Your Potential","Join Dr. Amanda Thompson as she shares insights and strategies \non harnessing the power of positive thinking to unlock your full potential \nand achieve personal and professional success.", "September 22, 2023","6:00pm","Dr. Amanda Thompson", 500,_lectureAdd);

    Address _ReceptionAdd = new Address("123 Desert Lane", "Phoenix", "AZ","USA",85001);
Receptions _reception = new Receptions("Reception","Harmony and Celebration: An Evening of Cultural Fusion", " Immerse yourself in a captivating blend of diverse cultures through music, dance, and cuisine, \nas we come together to celebrate unity and the beauty of cultural diversity at this enchanting reception.", "November 10, 2023","7:00 PM","culturalfusionreception@gmail.com", _ReceptionAdd);


Console.WriteLine();
Console.WriteLine("Standard Details");
_reception.StandardInformation();
Console.WriteLine();
_reception.FullDetails();
Console.WriteLine();
_reception.ShortDescription();
Console.WriteLine();
Console.WriteLine("Standard Details");
_lectures.StandardInformation();
Console.WriteLine();
_lectures.FullDetails();
Console.WriteLine();
_lectures.ShortDescription();
Console.WriteLine();
Console.WriteLine("Standard Details");
_outdoorGathering.StandardInformation();
Console.WriteLine();
_outdoorGathering.FullDetails();
Console.WriteLine();
_outdoorGathering.ShortDescription();