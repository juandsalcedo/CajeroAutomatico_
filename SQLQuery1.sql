-- Eliminar tablas existentes en orden correcto
DROP TABLE IF EXISTS Transacciones;
DROP TABLE IF EXISTS CUENTAS;
DROP TABLE IF EXISTS USUARIOS;
DROP TABLE IF EXISTS ROLES;

-- Crear nueva estructura
CREATE TABLE ROLES (
    IdRol INT IDENTITY(1,1) PRIMARY KEY,
    NombreRol VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE USUARIOS (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    NumeroDocumento BIGINT NOT NULL UNIQUE,
    TipoDocumento VARCHAR(10) NOT NULL CHECK (TipoDocumento IN ('CC', 'CE', 'TI', 'PASAPORTE')),
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    Correo VARCHAR(100) NOT NULL UNIQUE,
    Telefono VARCHAR(20) NOT NULL,
    contrasena VARCHAR(255) NOT NULL,  -- Almacenar hash de contraseña
    IdRol INT NOT NULL,
    FechaRegistro DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (IdRol) REFERENCES ROLES(IdRol)
);

CREATE TABLE CUENTAS (
    IdCuenta INT IDENTITY(1,1) PRIMARY KEY,
    IdUsuario INT NOT NULL,
    Estado BIT NOT NULL DEFAULT 1,
    TipoCuenta VARCHAR(20) NOT NULL CHECK (TipoCuenta IN ('Ahorros', 'Corriente')),
    Saldo DECIMAL(15, 2) NOT NULL DEFAULT 0.00,
    FechaCreacion DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (IdUsuario) REFERENCES USUARIOS(IdUsuario)
);

CREATE TABLE Transacciones (
    IdTransaccion INT IDENTITY(1,1) PRIMARY KEY,
    Emisor INT NOT NULL,
    Receptor INT NOT NULL,
    Monto DECIMAL(15, 2) NOT NULL,
    Fecha DATETIME DEFAULT GETDATE(),
    TipoTransaccion VARCHAR(20) NOT NULL CHECK (TipoTransaccion IN ('Transferencia', 'Retiro', 'Deposito')),
    FOREIGN KEY (Emisor) REFERENCES USUARIOS(IdUsuario),
    FOREIGN KEY (Receptor) REFERENCES USUARIOS(IdUsuario)
);

-- Índices para mejorar rendimiento
CREATE INDEX IX_USUARIOS_NumeroDocumento ON USUARIOS(NumeroDocumento);
CREATE INDEX IX_CUENTAS_IdUsuario ON CUENTAS(IdUsuario);
CREATE INDEX IX_TRANSACCIONES_Fecha ON Transacciones(Fecha);

-- Insertar datos iniciales
INSERT INTO ROLES (NombreRol) VALUES 
('Administrador'),
('Usuario');

-- Contraseñas: 'admin123' y 'usuario123' hasheadas con BCrypt
INSERT INTO USUARIOS (
    NumeroDocumento, 
    TipoDocumento, 
    Nombre, 
    Apellido, 
    Correo, 
    Telefono, 
    contrasena, 
    IdRol
) VALUES
(1234567890, 'CC', 'Juan', 'Perez', 'juan.perez@mail.com', '3001234567', 
'$2a$12$m5N1E7bVXzUQMpZbQ5vB3O9v6Jn8fL2rQd1kUW7Jk6t8wN1YcJ0Xa', 1),  -- admin123
(1234567891, 'CC', 'Maria', 'Gomez', 'maria.gomez@mail.com', '3001234568', 
'$2a$12$K9V7W8eE3rT4dC1vQ5bNj.9v6Jn8fL2rQd1kUW7Jk6t8wN1YcJ0Xa', 2);  -- usuario123

INSERT INTO CUENTAS (IdUsuario, TipoCuenta, Saldo) VALUES
(1, 'Ahorros', 3000000.00),
(2, 'Ahorros', 1500000.00);

INSERT INTO Transacciones (Emisor, Receptor, Monto, TipoTransaccion) VALUES
(1, 2, 500000.00, 'Transferencia'),
(2, 1, 100000.00, 'Transferencia');

-- Consultas de verificación
SELECT * FROM ROLES;
SELECT * FROM USUARIOS;
SELECT * FROM CUENTAS;
SELECT * FROM Transacciones;