CREATE TABLE Email (
    Id_Email INTEGER PRIMARY KEY AUTOINCREMENT,
    Subject TEXT NOT NULL,
    Body TEXT NOT NULL,
    IsRead BOOLEAN NOT NULL,
	Sender TEXT NOT NULL
);

CREATE TABLE MonAn (
    Id_MonAn INTEGER PRIMARY KEY AUTOINCREMENT,
    TenMonAn TEXT NOT NULL,
    MonAnURI TEXT NOT NULL,
    Id_Email INTEGER NOT NULL,
    FOREIGN KEY (Id_Email) REFERENCES Email(Id_Email)
);