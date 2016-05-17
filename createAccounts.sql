CREATE TABLE Destinations (
id int NOT NULL IDENTITY(1,1),
userName varchar(15) not null UNIQUE,
email varchar(50) not null UNIQUE,
hashedPassword varchar(128) not null,
salt varchar(16) not null
PRIMARY KEY(id)
)
