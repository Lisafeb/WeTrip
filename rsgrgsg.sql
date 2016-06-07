select * from Trips 
INNER JOIN Participants
ON Trips.creatorId=Participants.accountId WHERE Trips.creatorId=4