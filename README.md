# Swimming-competition
Full stack server-client C# application in .NET.

User of the application is a swimming competition administrator, who manages ongoing competitions. Application enables him to create new competitions or delete existing comeptitions. It allows him to apply swimmers for new competitions, as well as edit or delete them from the system. Administrator is in charge of inserting competition results for each swimmer after the competition.

Three tier architecture is implemented. Presentation Tier UI is done with Windows Forms and the communication with the Bussines Tier is managed through UIControler. Bussines Tier contains Controler in charge of communicating with the UIControler, Bussines logic consisting of Domain Classes and System Operations, and the final part is DatabaseBroker. DBB communicates with SQL Database which stores information about the system.

Further development possibilities include creating a better UI for the administrator user; adding competitors as application users and adding other funcionalities and competitors profile conatining their history. 

Software design process is fully documented in the included project documentation written in Serbian.
