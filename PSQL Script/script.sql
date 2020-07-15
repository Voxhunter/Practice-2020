CREATE TABLE Comp
(
    "comp_Id" SERIAL PRIMARY KEY,
    "comp_Name" VARCHAR(50) NOT NULL
);
  
CREATE TABLE Work
(
    "work_Id" SERIAL PRIMARY KEY,
    "comp_Id" INTEGER,
    "work_Name" VARCHAR(50) NOT NULL,
    FOREIGN KEY ("comp_Id") REFERENCES Comp ("comp_Id") ON DELETE CASCADE ON UPDATE CASCADE
	);