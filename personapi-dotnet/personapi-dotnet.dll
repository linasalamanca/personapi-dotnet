IF DB_ID('persona_db') IS NULL
BEGIN
    CREATE DATABASE persona_db;
END
GO

CREATE TABLE persona_db.profesion (
    id INT PRIMARY KEY,
    nom VARCHAR(90),
    des TEXT
);

CREATE TABLE persona_db.persona (
  cc INT PRIMARY KEY,
  nombre VARCHAR(45),
  apellido VARCHAR(45),
  genero CHAR(1) CHECK (genero IN ('M', 'F')), -- Restricción CHECK
  edad INT
);


CREATE TABLE persona_db.estudios (
  id_prof INT,
  cc_per INT,
  fecha DATE,
  univer VARCHAR(50),
  PRIMARY KEY (id_prof, cc_per),
  FOREIGN KEY (id_prof) REFERENCES persona_db.profesion(id),
  FOREIGN KEY (cc_per) REFERENCES persona_db.persona(cc)
);


CREATE TABLE persona_db.telefono (
    num VARCHAR(15) PRIMARY KEY,
    oper VARCHAR(45),
    duenio INT,
    FOREIGN KEY (duenio) REFERENCES persona_db.persona(cc)
);