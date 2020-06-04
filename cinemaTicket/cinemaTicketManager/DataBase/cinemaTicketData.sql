use cinemaTicket

insert into category(catName) values
(N'Action Movies'),
(N'Historical Movies'),
(N'Horror Movies'),
(N'Fantasy Movies'),
(N'Legend Movies'),
(N'Psychological Movies'),
(N'War Movies'),
(N'Adventure Movies'),
(N'Romatic Movies')
go

insert into showroom(roomName, status) values
(N'Room 1',1),
(N'Room 2',1),
(N'Room 3',1),
(N'Room 4',1),
(N'Room 5',1),
(N'Room 6',1),
(N'Room 7',1),
(N'Room 8',1),
(N'Room 9',1)
go

insert into seat(seatName,type,price) values
(N'A1',0,0),(N'A2',0,0),(N'A3',0,0),(N'A4',0,0),(N'A5',0,0),(N'A6',0,0),(N'A7',0,0),(N'A8',0,0),(N'A9',0,0),(N'A10',0,0),
(N'B1',0,0),(N'B2',0,0),(N'B3',0,0),(N'B4',0,0),(N'B5',0,0),(N'B6',0,0),(N'B7',0,0),(N'B8',0,0),(N'B9',0,0),(N'B10',0,0),
(N'C1',0,0),(N'C2',0,0),(N'C3',0,0),(N'C4',0,0),(N'C5',0,0),(N'C6',0,0),(N'C7',0,0),(N'C8',0,0),(N'C9',0,0),(N'C10',0,0),
(N'D1',0,1),(N'D2',0,1),(N'D3',0,1),(N'D4',0,1),(N'D5',0,1),(N'D6',0,1),(N'D7',0,1),(N'D8',0,1),(N'D9',0,1),(N'D10',0,1),
(N'E1',0,1),(N'E2',0,1),(N'E3',0,1),(N'E4',0,1),(N'E5',0,1),(N'E6',0,1),(N'E7',0,1),(N'E8',0,1),(N'E9',0,1),(N'E10',0,1),
(N'H1',0,1),(N'H2',0,1),(N'H3',1,3),(N'H4',1,3),(N'H5',1,3),(N'H9',0,1),(N'H10',0,1),
(N'G1',1,3),(N'G2',1,3),(N'G3',1,3),(N'G4',1,3),(N'G5',1,3)
go

insert into showtime(timeName,timeBegin, timeEnd) values
(N'8h00AM - 10h30AM',480,630),
(N'10h40AM - 1h10PM',640,790),
(N'1h10PM - 3h50PM',800,950),
(N'4h00PM - 6h30PM',960,1110),
(N'6h40PM - 9h10PM ',1120,1270)
go
/*1*/
insert into film(filmName,time, director, casts, ariDate, numDateShow, content, image, catId) values
/*1,2,3*/(N'How to Train Your Dragon 3: The Hidden World',104,N'Dean Deblois',N'Jay Baruchel,America Ferrera,F. Murray Abraham,Cate Blanchett,Craig Ferguson,Jonah Hill,...',GETDATE(),50,N'After Hiccup created a peaceful world for dragons, Tooth Saw discovered a mysterious new friend. Hiccup has now become the leader of the whole village, carrying the burden of keeping everyone safe. Therefore, he cannot be forever swept away by endless adventures with Tooth Sún. And when danger strikes the village, both Hiccup and Rang have stood up, bravely defending their species.','How_to_Train_Your_Dragon.jpg',1),
/*1,2,3,4*/(N'Alita: Battle Angel',122,N'Robert Rodriguez',N'Rosa Salazar,Christoph Waltz,Jennifer Connelly,Mahershala Ali,Ed Skrein,Jackie Earle Haley,...',GETDATE(),50,N'Alita is compared to a god of death from hell because of the ability to overcome all the limits she possesses. She was found by Dr. Ido and can''t remember who she is or where she came from. In order to find the truth, Atila had to embark on fierce battles.','alita.jpg',1),
/*1,2*/(N'Glass - Trio',129,N'M. Night Shyamalan',N'James Mcavoy,Bruce Willis,Samuel L. Jackson,Anya Taylor-Joy,Sarah Paulson,Spencer Treat Clark,...',GETDATE(),50,N'For the first time, the audience will witness the meeting of two mutants from the movie world directed by M. Night Shyamalan: Kevin Wendell Crumb - who has 23 personalities in the film Split and David Dunn - the man Never been injured in Unbreakable .','Glass.jpg',1),
/*1,2,3,4*/(N'Avengers 4: Endgame',149 ,N'Anthony Russo, Joe Russo',N'Robert Downey,Chris Evans,Mark Ruffalo,Chris Hemsworth,Scarlett Johanson,Jeremy Renner,...',GETDATE(),50,N'Avengers 4: Endgame (Avengers 4: Endgame) released in April 2019 will thoroughly solve the problems that have been outlined in the previous 22 movies of the Marvel Cinematic Universe (MCU). Two months later, Spider-Man 2 is a completely new start for the MCU.\n\nAfter Thanos caused half of the universe to dissolve and make the Avengers a failure, surviving superheroes must participate in the final battle in Avengers: Endgame.','Avengers_Endgame.jpg',1),
/*1,2,3*/(N'Men in Black: International',114,N'F. Gary Gray',N'Chris Hemsworth,Tessa Thompson,Rebecca Ferguson,Rafe Spall,Emma Thompson,Kumail Nanjiani,...',GETDATE(),50,N'For a long time, Agent Black Shirt has always been the coolest silent heroes, protecting the Earth from evil alien threats. In this new adventure, they face the biggest global threat ever: finding the double agent hidden in Men In Black','black.jpg',1),
/*1,2*/(N'King Godzilla: King of the Monsters',131,N'Warner Bros',N'Kyle Chandler,Vera Farmiga,Millie Bobby Brown,Ken Watanabe,Zhang Ziyi,Bradley Whitford,...',GETDATE(),50,N'The arrival of Godzilla in the past led humans to discover the ancient Titan creatures that still exist on Earth. After the battle to defeat the enemy, Godzilla disappeared into the sea. One day, the three-headed Ghidorah Dragon rose with the awakening of hundreds of giant monsters. All they want is to fight for supremacy, to dominate the world. In this unprecedented battle of destruction in history, will Godzilla''s "Lord of all" return and be the "savior" of mankind before the peril of destruction?','Godzilla.jpg',1),
/*3,4,5*/(N'Hellboy',120,N'Neil Marshall',N'Mark Stanley,Brian Gleeson,Milla Jovovich,Penelope Mitchell,Ian Mcshane,David Harbour,...',GETDATE()+2,50,N'Adapted based on the famous comic series of the same name by Mike Mignola, the "reboot" Hellboy is the battle between "Red Devil" (David Harbor - Stranger Things) and an ancient evil woman (Milla Jovovich - Resident Evil ) are planning to destroy humanity.','hellboy.jpg',1),
/*3,4,5*/(N'Fast & Furious Presents: Hobbs & Shaw',137,N'David Leitch',N'Dwayne Johnson,Jason Statham,Idris Elba,Vanessa Kirby,Helen Mirren,Eiza González,...',GETDATE()+2,50,N'After 8 movies with a worldwide gross of $ 5 billion, Fast & Furious will now return to a completely independent side story starring Dwayne Johnson as Luke Hobbs and Jason Statham. as Deckard Shaw in Hobbs & Shaw.\n\nThe story between two people who seem to be in the sky is the US Foreign Service Specialist Luke Hobbs and the notorious mercenary criminal Deckard Shaw when they are reluctant to work together to prevent the plot of the villainous boss. extremely dangerous in the mysterious Brixton.','Hobbs_and_Shaw.jpg',1),
/*4,5,6*/(N'John Wick: Chapter 3 - Parabellum',131,N'Chad Stahelski',N'Keanu Reeves,Halle Berry,Ian Mcshane,Laurence Fishbuner,Lance Reddick,Tobias Segal,...',GETDATE()+3,50,N'After becoming the "big prize" of the global assassin, super assassin John Wick must accompany the pet dog to flee. At $ 14 million, John Wick has become a lucrative target for any human head hunter.','John_Wick_3.jpg',1),
/*4,5,6,7*/(N'Jumanji: Welcome to the Jungle',119,N'Matt Tolmach',N'Karen Gillan,Dwayne Johnson,Miss Pyle,Jack Black,Madison Iseman,Kevin Hart,...',GETDATE()+3,50,N'Following a group of 4 high school students who were fined to clean up the school basement. There, they discovered a classic game version called Jumanji. All 4 proceed to choose the character and start playing, but no doubt they were swept into the world inside the game and live with the appearance, character characteristics previously selected','Jumanji_3.jpg',1),
/*5,6,7*/(N'Spider-Man: Far from Home',129,N'Jon Watts',N'Tom Holland,Samuel L. Jackson,Jake Gyllenhaal,Marisa Tomei,Jon Favreau,Zendaya,...',GETDATE()+4,50,N'After the Infinity War, Spider-Man Peter Parker and a group of close friends joined the school''s European tour. However, Peter ''s plan to take a leave of absence is quickly canceled after he agrees to help Nick Fury discover the mystery of the attacks of elemental forces that are ravaging the continent.','Spider-Man.jpg',1),
/*5,6,7*/(N'Terminator Genisys',126,N'Alan Taylor',N'Arnold Schwarzenegger,Jason Clarke,Emilia Clarke,Jai Courtney,J.k. Simmons,Dayo Okeniyi,...',GETDATE()+4,50,N'Part 5 of the Terminator will focus on the event before Sarah Connor disappears between Terminator 2: Judgment Day and Terminator 3: Rise of the Machines. During this time viewers will be exposed to the true form of the T-800 Terminator in human form, which means that later on why the character''s model was chosen by Skynet for the return times. past tense.','Terminator_5.jpg',1),
/*6,7*/(N'The Secret Life of Pets 2',167,N'Illumination Entertainment',N'Patton Oswalt,Eric Stonestreet,Kevin Hart,Lake Bell,Dana Carvey,Albert Brooks,...',GETDATE()+5,50,N'Like other pets, when Max came to the clinic, he couldn''t hide his anxiety. Moreover, the poor dog also met many extremely unusual friends. The first is the friendly gray cat talking to Max, reassuring him that the vet here is the best in the field of treatment ... behavior disorders. And then the cat began to "rage" at the owner. Max then met the gray hamster, who was madly "jogging" to lose weight, a brown dog always wondered if he was good enough, and a pair of twin cats with extremely weird smiles. Avoiding the shell again, Max was anxious, becoming even more scared with the immediate examination.','The_Secret_Life_of_Pets_2.jpg',1),
/*6,7*/(N'X-Men 8: Dark Phoenix',113,N'Simon Kinberg',N'Jennifer Lawrence,Jessica Chastain,Olivia Munn,James Mcavoy,Tye Sheridan,Sophie Turner,...',GETDATE()+5,50,N'X-Men: Dark Phoenix is an extension of the X-Men universe when Jean Gray awakens and acquires the Phoenix Force - representing the total energy, the power of all things that have been and always exists. in. Endless sources of power gave Jean Gray terrible power, but the dark side of strength also awakened. What will the X-Men do to prevent the destruction of mankind caused by Jean Gray and the Phoenix Force?','X-Men_Dark_Phoenix.jpg',1),
/*7*/(N'Shazam',132,N'David F. Sandberg ',N'Zachary Levi,Jack Dylan Grazer,Mark Strong,Adam Brody,Djimon Hounsou,Fare Herman,...',GETDATE()+6,50,N'We are all heroes, the problem is that we have to know how to develop our abilities. In the case of Bill Batson (Angel), with the help of an ancient witch, just say aloud the word "Shazam!" is a 14-year-old child who can transform into an adult Shazam (Levi). But inside a god-like body is still the heart of a child.\n\nThe name Shazam is based on the first letter of the mighty gods of Solomon, Hercules, Atlas, Zeus, Achilles and Mercury.','Shazam.png',1)
go

insert into account(name,dob,phone,email,address,userName,password,role) values
(N'Tom Hiddleston','1999-12-23','0963215663','tom2312@gmail.com',N'Virginia Ave, Columbia, MO 65201, USA','tomHiddleston','12345$',1)
go

/* CalenderShow GetDate() */
insert into calendershow(film,showTime,showRoom,showDate,extraPrice) values
(1,1,1,getdate(),5),(2,1,2,getdate(),5),(4,1,3,getdate(),5),(6,1,4,getdate(),5),
(3,2,2,getdate(),5),(5,2,4,getdate(),5),(1,2,6,getdate(),5),(2,2,9,getdate(),5),
(1,3,4,getdate(),5),(5,3,5,getdate(),5),(6,3,7,getdate(),5),(3,3,9,getdate(),5),
(2,4,1,getdate(),5),(4,4,3,getdate(),5),(3,4,6,getdate(),5),(4,4,8,getdate(),5),
(1,5,8,getdate(),5),(2,5,3,getdate(),5)
go

/* CalenderShow GetDate() + 1 */
insert into calendershow(film,showTime,showRoom,showDate,extraPrice) values
(1,1,2,getdate()+1,5),(2,1,6,getdate()+1,5),(4,1,7,getdate()+1,5),(6,1,9,getdate()+1,5),
(3,2,1,getdate()+1,5),(5,2,3,getdate()+1,5),(1,2,5,getdate()+1,5),(2,2,8,getdate()+1,5),
(1,3,2,getdate()+1,5),(5,3,4,getdate()+1,5),(6,3,7,getdate()+1,5),
(2,4,1,getdate()+1,5),(4,4,3,getdate()+1,5),(3,4,5,getdate()+1,5),(4,4,8,getdate()+1,5),
(1,5,2,getdate()+1,5),(2,5,4,getdate()+1,5),(3,5,9,getdate()+1,5)
go

/* CalenderShow GetDate() + 2 */
insert into calendershow(film,showTime,showRoom,showDate,extraPrice) values
(1,1,3,getdate()+2,5),(2,1,4,getdate()+2,5),(4,1,6,getdate()+2,5),(5,1,9,getdate()+2,5),
(7,2,1,getdate()+2,5),(8,2,5,getdate()+2,5),(4,2,7,getdate()+2,5),
(8,3,2,getdate()+2,5),(4,3,3,getdate()+2,5),(1,3,6,getdate()+2,5),(7,3,9,getdate()+2,5),
(2,4,1,getdate()+2,5),(5,4,2,getdate()+2,5),(7,4,5,getdate()+2,5),(4,4,8,getdate()+2,5),
(8,5,2,getdate()+2,5),(7,5,4,getdate()+2,5),(2,2,6,getdate()+2,5)
go

/* CalenderShow GetDate() + 3 */
insert into calendershow(film,showTime,showRoom,showDate,extraPrice) values
(2,1,1,getdate()+3,5),(4,1,5,getdate()+3,5),(7,1,8,getdate()+3,5),
(8,2,2,getdate()+3,5),(10,2,4,getdate()+3,5),(9,2,6,getdate()+3,5),(7,2,9,getdate()+3,5),
(4,3,1,getdate()+3,5),(9,3,3,getdate()+3,5),(8,3,4,getdate()+3,5),(10,3,8,getdate()+3,5),
(9,4,5,getdate()+3,5),(8,4,6,getdate()+3,5),(2,4,7,getdate()+3,5),(7,4,9,getdate()+3,5),
(8,5,8,getdate()+3,5),(9,5,3,getdate()+3,5),(10,1,4,getdate()+3,5)
go

/* CalenderShow GetDate() + 4 */
insert into calendershow(film,showTime,showRoom,showDate,extraPrice) values
(11,1,1,getdate()+4,5),(12,1,2,getdate()+4,5),(7,1,3,getdate()+4,5),(9,1,4,getdate()+4,5),
(8,2,2,getdate()+4,5),(10,2,4,getdate()+4,5),(7,2,6,getdate()+4,5),(11,2,9,getdate()+4,5),
(12,3,4,getdate()+4,5),(10,3,5,getdate()+4,5),(9,3,7,getdate()+4,5),(8,3,9,getdate()+4,5),
(10,4,1,getdate()+4,5),(12,4,3,getdate()+4,5),(11,4,6,getdate()+4,5),(7,4,8,getdate()+4,5),
(10,5,8,getdate()+4,5),(12,5,3,getdate()+4,5)
go

/* CalenderShow GetDate() + 5 */
insert into calendershow(film,showTime,showRoom,showDate,extraPrice) values
(11,1,3,getdate()+5,5),(10,1,4,getdate()+5,5),(14,1,6,getdate()+5,5),(13,1,9,getdate()+5,5),
(12,2,1,getdate()+5,5),(11,2,2,getdate()+5,5),(10,2,5,getdate()+5,5),(9,2,8,getdate()+5,5),
(13,3,4,getdate()+5,5),(9,3,6,getdate()+5,5),(10,3,7,getdate()+5,5),(12,3,9,getdate()+5,5),
(10,4,1,getdate()+5,5),(12,4,3,getdate()+5,5),(9,4,5,getdate()+5,5),(11,4,8,getdate()+5,5),
(13,5,2,getdate()+5,5),(12,5,6,getdate()+5,5),(14,5,7,getdate()+5,5)
go

/* CalenderShow GetDate() + 6 */
insert into calendershow(film,showTime,showRoom,showDate,extraPrice) values
(10,1,1,getdate()+6,5),(12,1,3,getdate()+6,5),(14,1,5,getdate()+6,5),
(13,2,2,getdate()+6,5),(15,2,4,getdate()+6,6),(14,2,6,getdate()+6,5),(12,2,9,getdate()+6,5),
(11,3,1,getdate()+6,5),(12,3,5,getdate()+6,5),(14,3,7,getdate()+6,5),(13,3,9,getdate()+6,5),(15,1,8,getdate()+6,6),
(10,4,2,getdate()+6,5),(14,4,5,getdate()+6,5),(13,4,6,getdate()+6,5),(12,4,8,getdate()+6,5),
(15,5,8,getdate()+6,6),(11,5,7,getdate()+6,5)
go

/* CalenderShow GetDate() + 7 */
insert into calendershow(film,showTime,showRoom,showDate,extraPrice) values
(12,1,3,getdate()+7,5),(12,1,4,getdate()+7,5),(14,1,6,getdate()+7,5),(15,1,9,getdate()+7,5),
(13,2,1,getdate()+7,5),(15,2,5,getdate()+7,5),(14,2,7,getdate()+7,5),(12,3,8,getdate()+7,5),
(14,3,2,getdate()+7,5),(15,3,3,getdate()+7,5),(15,3,6,getdate()+7,5),(13,3,9,getdate()+7,5),
(12,4,1,getdate()+7,5),(14,4,2,getdate()+7,5),(13,4,5,getdate()+7,5),(15,4,8,getdate()+7,5),
(4,5,2,getdate()+7,5),(14,5,4,getdate()+7,5),(15,2,6,getdate()+7,5)
go

select * from account
select * from seat
select * from calendershow
select * from ticket