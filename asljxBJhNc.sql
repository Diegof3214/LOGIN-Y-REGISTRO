-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 20-07-2021 a las 23:33:28
-- Versión del servidor: 8.0.13-4
-- Versión de PHP: 7.2.24-0ubuntu0.18.04.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `asljxBJhNc`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ajuste`
--

CREATE TABLE `ajuste` (
  `Idcontra` int(11) NOT NULL,
  `CONTRASEÑA` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `ajuste`
--

INSERT INTO `ajuste` (`Idcontra`, `CONTRASEÑA`) VALUES
(1, 'PASSWORD');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `area`
--

CREATE TABLE `area` (
  `IDAREA` int(11) NOT NULL,
  `AREA` varchar(50) NOT NULL,
  `NOMBRE` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci ROW_FORMAT=COMPACT;

--
-- Volcado de datos para la tabla `area`
--

INSERT INTO `area` (`IDAREA`, `AREA`, `NOMBRE`) VALUES
(1, '1. COMUNICACION', 'COMUNICACION'),
(2, '2. INGLES', 'INGLES'),
(3, '3. CIENCIAS SOCIALES', 'CIENCIAS SOCIALES'),
(4, '4. DESARROLLO PERSONAL, CIUDADANIA Y CIVICA', 'DESARROLLO PERSONAL, CIUDADANIA Y CIVICA'),
(5, '5. EDUCACION RELIGIOSA', 'EDUCACION RELIGIOSA'),
(6, '6. MATEMATICA', 'MATEMATICA'),
(7, '7. ARTE Y CULTURA', 'ARTE Y CULTURA'),
(8, '8. EDUCACION FISICA', 'EDUCACION FISICA'),
(9, '9. CIENCIA, TECNOLOGIA Y AMBIENTE', 'CIENCIA, TECNOLOGIA Y AMBIENTE'),
(10, '10. INGENIERIA', 'INGENIERIA');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asistencia`
--

CREATE TABLE `asistencia` (
  `IDASIS` int(11) NOT NULL,
  `INASISTENCIA` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `asistencia`
--

INSERT INTO `asistencia` (`IDASIS`, `INASISTENCIA`) VALUES
(1, 'Si'),
(2, 'No');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `docente`
--

CREATE TABLE `docente` (
  `IdDocente` int(11) NOT NULL,
  `Docente` varchar(50) NOT NULL,
  `AREA` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `docente`
--

INSERT INTO `docente` (`IdDocente`, `Docente`, `AREA`) VALUES
(1, 'ASCENCIO QUISPE, JHON MILTON', 1),
(2, 'AVILÉS ALFARO, PEDRO RAMÓN', 1),
(3, 'ECOS HERNÁNDEZ, LUIS AGUSTÍN', 1),
(4, 'ESCATE HERNÁNDEZ, JULIO CÉSAR', 1),
(5, 'FLORES RAMOS, MARIA ANTONIA ', 1),
(6, 'GASTELÚ CÁRDENAS, VÍCTOR ALFREDO', 1),
(7, 'GRANDA QUISPE, MARÍA MARGARITA   ', 1),
(8, 'MISAICO CONTRERAS, SONIA AMPARO', 1),
(9, 'GONZALES ALVAREZ, MARGORI MARILUZ (C)', 1),
(10, 'MEJÍA MORALES, REYNA ISABEL (C)', 1),
(11, 'RAMOS HUAMÁN, MARÍA ESTELA (C)', 1),
(12, 'GIRAO ARAUJO, PETRONILA ROSARIO', 2),
(13, 'HUAMÁN CORDERO, MARÍA OFELIA', 2),
(14, 'TIPTE QUISPE, SILVIA PILAR', 2),
(15, 'VÁSQUEZ BENITES, WILLAMS AMARO', 2),
(16, 'QUISPE DE LA CRUZ, HAYDEE DENISSE (C)', 2),
(17, 'ANTONIO RAZABAL, TOMAS ROLANDO', 3),
(18, 'CARLOS ANTONIO, REBECA', 3),
(19, 'CHÁVEZ GARCÍA, FREDDY LUIS', 3),
(20, 'DONAYRE ANICAMA, JORGE LUIS', 3),
(21, 'VERA BANCAYAN, MANUEL PAULO', 3),
(22, 'INCAHUANACO MAMANI; WILMER JACINTO (C)', 3),
(23, 'CANALES GARAY, GISELA EDITH', 4),
(24, 'ESCATE QUISPE, YENY ROSA', 4),
(25, 'FIGUEROA GARCÍA, SARA SOFÍA', 4),
(26, 'ROJAS CONTRERAS, LUZ MARLENI', 4),
(27, 'SIGUAS SAM, VÍCTOR ALEJANDRO', 4),
(28, 'FALCONÍ URIBE, EDISON STEVEN (C)', 4),
(29, 'GONZALES NORABUENA, LUIS ANTONIO (C)', 4),
(30, 'CUPE CUENCA, MAXIMO ALBERTO', 5),
(31, 'HERNÁNDEZ  ACASIETE, CARLOS ALBERTO', 5),
(32, 'MONTENEGRO GUERRA, JOSE ALEJANDRO', 5),
(33, 'RIOS OYAGUE, JESSICA YVONET (C)', 5),
(34, 'MARTÍNEZ GARCÍA DE HERNÁNDEZ, JULIA DORA (C)', 5),
(35, 'AURIS ESCOBAR, JANET ROSSANA', 6),
(36, 'CONDORÍ BARRIENTOS; EDITH ELENA', 6),
(37, 'CORTÉZ HUAMANÍ, MARIO EFRAÍN', 6),
(38, 'GAMONAL JERONIMO, JULIA ELENA', 6),
(39, 'GARCIA MUÑOZ, ELEUTERIO JUAN', 6),
(40, 'PALOMINO AGUIRRE, JUAN NÉSTOR', 6),
(41, 'REYES MORAN, SALLY LEONELLA', 6),
(42, 'LEDESMA CERPA, LUIS VENANCIO (C)', 6),
(43, 'MARTINEZ MALDONADO, ALEX DANIEL (C)', 6),
(44, 'VILLAVERDE LUCANA, DANITZA SUSAN (C)', 6),
(45, 'MENDOZA PECHO, PABLO TEODORO', 7),
(46, 'CHAPARRO ECHEGARAY, PERCY DANIEL', 7),
(47, 'RAMOS MENDOZA, MÓNICA LISSETE', 7),
(48, 'ACUÑA MENDIVIL, RAQUEL JUDITH (C)', 7),
(49, 'HUARACA SOLIS, ROSALÍA LILIANA (C)', 7),
(50, 'APARCANA ASCENCIO, MANUEL WILFREDO', 8),
(51, 'ALARCÓN VEGA, MOISÉS VALENTÍN', 8),
(52, 'ESPINO BALDIÑO, JOSÉ VLADIMIR', 8),
(53, 'WESTON FERREYRA, JUAN ALFREDO', 8),
(54, 'HERNÁNDEZ PALACIOS, GUILLERMO ALEXIS (C)', 8),
(55, 'CABRERA VIZARRETA, MARTHA LUISA', 9),
(56, 'CACERES GUTIERREZ, SERGIO AUGUSTO', 9),
(57, 'HERNÁNDEZ ESCOBAR, LESTY CAMILA', 9),
(58, 'REYES HERNANDEZ, REYDER NILTON ', 9),
(59, 'YARMA ASTOCAZA, ESTELA VICENTA', 9),
(60, 'CASTRO CHACALTANA, ELIA LUISA (C)', 9),
(61, 'GARCIA SOLLER, TANIA MIRTHA (C)', 9),
(62, 'RUBIANES HUAMÁN, ARACELY GUADALUPE (C)', 9),
(63, 'ESCATE CORNEJO, ERICKA (C)', 9),
(65, 'JUAN JOSE JAYO LEGARIO', 10);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `monitoreo`
--

CREATE TABLE `monitoreo` (
  `IDMONITOREO` int(11) NOT NULL,
  `NOMBRE DEL PROFESOR` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `AREA` varchar(50) NOT NULL,
  `HORA DE ENTRADA` varchar(50) NOT NULL,
  `HORA DE SALIDA` varchar(50) NOT NULL,
  `FECHA` varchar(50) NOT NULL,
  `TURNO` varchar(50) NOT NULL,
  `INASISTENCIA` varchar(50) NOT NULL,
  `NUMERO DE ALUMNOS` int(11) NOT NULL,
  `NUMERO DE COMPUTADORAS USADAS` int(11) DEFAULT NULL,
  `SOFTWARE` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `TEMA` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `AULA` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `monitoreo`
--

INSERT INTO `monitoreo` (`IDMONITOREO`, `NOMBRE DEL PROFESOR`, `AREA`, `HORA DE ENTRADA`, `HORA DE SALIDA`, `FECHA`, `TURNO`, `INASISTENCIA`, `NUMERO DE ALUMNOS`, `NUMERO DE COMPUTADORAS USADAS`, `SOFTWARE`, `TEMA`, `AULA`) VALUES
(2, 'ROJAS CONTRERAS, LUZ MARLENI', '4', '17:46 p.m.', '18:46 p.m.', '04/14/2020', 'Tarde', 'No', 30, 12, 'Microsoft Word', '312', 'GRADO - SECCION'),
(4, 'ESCATE QUISPE, YENY ROSA', '4', '11:35 a.m.', '12:35 p.m.', '04/13/2020', 'Mañana', 'No', 12, 11, 'Microsoft Word', '312', 'GRADO - SECCION'),
(5, 'HERNÁNDEZ ESCOBAR, LESTY CAMILA', '9', '15:29 p.m.', '16:29 p.m.', '04/14/2020', 'Tarde', 'No', 123, 12, 'GeoGebra', '32', 'GRADO - SECCION'),
(21, 'AVILÉS ALFARO, PEDRO RAMÓN', '1', '16:40 p.m.', '15:51 p.m.', '04/19/2020', 'Tarde', 'No', 21, 21, 'Microsoft PowerPoint', 'PRUEBA', '1 - D'),
(22, 'HUAMÁN CORDERO, MARÍA OFELIA', '2', '17:40 p.m.', '15:54 p.m.', '04/19/2020', 'Mañana', 'Si', 21, 20, 'Microsoft Word', 'CLASE', '5 - A'),
(23, 'AVILÉS ALFARO, PEDRO RAMÓN', '1', '18:55 p.m.', '18:56 p.m.', '04/19/2020', 'Mañana', 'No', 40, 40, 'Microsoft Excel\r\n', 'XXX', '5 - D'),
(24, 'CARLOS ANTONIO, REBECA', '3', '14:24 p.m.', '15:25 p.m.', '04/20/2020', 'Mañana', 'No', 123, 42, 'Microsoft Word', '2', '2 - C'),
(26, 'ASCENCIO QUISPE, JHON MILTON', '1', '17:31 p.m.', '17:32 p.m.', '04/20/2020', 'Mañana', 'No', 40, 40, 'CmapTools\r\n', 'XXX', '5 - D'),
(27, 'ASCENCIO QUISPE, JHON MILTON', '1', '17:37 p.m.', '17:38 p.m.', '04/20/2020', 'Mañana', 'No', 40, 40, 'GeoGebra', 'ZZZ', '4 - Z'),
(28, 'ASCENCIO QUISPE, JHON MILTON', '1', '17:45 p.m.', '17:46 p.m.', '04/20/2020', 'Mañana', 'No', 40, 40, 'Google Earth', 'XXX', '4 - D'),
(30, 'CARLOS ANTONIO, REBECA', '3', '17:42 p.m.', '17:43 p.m.', '04/22/2020', 'Mañana', 'No', 40, 40, 'CmapTools\r\n', 'HHH', '5 - G'),
(31, 'RIOS OYAGUE, JESSICA YVONET (C)', '5', '19:21 p.m.', '19:22 p.m.', '04/23/2020', 'Tarde', 'No', 45, 45, 'Clase', 'WWW', '5 - B'),
(37, 'JUAN JOSE JAYO LEGARIO', '10', '23:56 p.m.', '23:57 p.m.', '06/10/2020', 'Noche', 'No', 45, 45, 'Matlab', 'PRUEBA', '5 - D'),
(38, 'ASCENCIO QUISPE, JHON MILTON', '1', '08:00 a.m.', '09:30 a.m.', '08/02/2020', 'Mañana', 'No', 30, 15, 'CmapTools\r\n', 'LOS ANIMALITOS', '4 - A'),
(39, 'RAMOS HUAMÁN, MARÍA ESTELA (C)', '1', '10:30 a.m.', '12:00 p.m.', '08/02/2020', 'Mañana', 'No', 31, 30, 'CmapTools\r\n', 'LA COMUNICACIÓN', '4 - X');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `recursos`
--

CREATE TABLE `recursos` (
  `IDRECUR` int(11) NOT NULL,
  `DOCENTE` int(11) DEFAULT NULL,
  `NUMERO DE ALUMNOS` int(11) NOT NULL,
  `NUMERO DE COMPUTADORAS USADAS` int(11) NOT NULL,
  `SOFTWARE` int(11) DEFAULT NULL,
  `FECHA` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `software`
--

CREATE TABLE `software` (
  `Idsoft` int(11) NOT NULL,
  `SOFTWARE` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `software`
--

INSERT INTO `software` (`Idsoft`, `SOFTWARE`) VALUES
(1, 'CmapTools\r\n'),
(2, 'Microsoft Excel\r\n'),
(3, 'Microsoft PowerPoint'),
(4, 'Microsoft Word'),
(5, 'GeoGebra'),
(6, 'JClic'),
(7, 'Hot Potatoes'),
(8, 'Scratch'),
(9, 'Google Earth'),
(10, 'WPS Office'),
(11, 'Clase'),
(18, 'Matlab');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `turno`
--

CREATE TABLE `turno` (
  `Id` int(11) NOT NULL,
  `Turno` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci ROW_FORMAT=COMPACT;

--
-- Volcado de datos para la tabla `turno`
--

INSERT INTO `turno` (`Id`, `Turno`) VALUES
(1, 'Mañana'),
(2, 'Tarde'),
(18, 'Noche');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `Id` int(11) NOT NULL,
  `Nombres` varchar(100) NOT NULL,
  `Apellidos` varchar(100) NOT NULL,
  `Correo` text NOT NULL,
  `Usuario` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci ROW_FORMAT=COMPACT;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`Id`, `Nombres`, `Apellidos`, `Correo`, `Usuario`, `Password`) VALUES
(1, 'NOMBRE', 'APELLIDO', 'EMAIL', 'USUARIO', 'CONTRASEÑA'),
(2, 'ASD', 'ASD', 'AD', '123', '1212'),
(3, 'MONICA GABRIELA', 'SALCEDO HERNANDEZ', 'monica_sh10_7@hotmail.com', 'MSALCEDO', 'PASSWORD');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `area`
--
ALTER TABLE `area`
  ADD PRIMARY KEY (`IDAREA`,`AREA`);

--
-- Indices de la tabla `asistencia`
--
ALTER TABLE `asistencia`
  ADD PRIMARY KEY (`IDASIS`,`INASISTENCIA`);

--
-- Indices de la tabla `docente`
--
ALTER TABLE `docente`
  ADD PRIMARY KEY (`IdDocente`),
  ADD KEY `docente_ibfk_1` (`AREA`);

--
-- Indices de la tabla `monitoreo`
--
ALTER TABLE `monitoreo`
  ADD PRIMARY KEY (`IDMONITOREO`),
  ADD UNIQUE KEY `IDMONITOREO` (`IDMONITOREO`),
  ADD KEY `AREA` (`AREA`),
  ADD KEY `NOMBRE DEL PROFESOR` (`NOMBRE DEL PROFESOR`),
  ADD KEY `TURNO` (`TURNO`),
  ADD KEY `INASISTENCIA` (`INASISTENCIA`);

--
-- Indices de la tabla `recursos`
--
ALTER TABLE `recursos`
  ADD PRIMARY KEY (`IDRECUR`),
  ADD KEY `DOCENTE` (`DOCENTE`),
  ADD KEY `SOFTWARE` (`SOFTWARE`);

--
-- Indices de la tabla `software`
--
ALTER TABLE `software`
  ADD PRIMARY KEY (`Idsoft`);

--
-- Indices de la tabla `turno`
--
ALTER TABLE `turno`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `area`
--
ALTER TABLE `area`
  MODIFY `IDAREA` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT de la tabla `asistencia`
--
ALTER TABLE `asistencia`
  MODIFY `IDASIS` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `docente`
--
ALTER TABLE `docente`
  MODIFY `IdDocente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=66;

--
-- AUTO_INCREMENT de la tabla `monitoreo`
--
ALTER TABLE `monitoreo`
  MODIFY `IDMONITOREO` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT de la tabla `recursos`
--
ALTER TABLE `recursos`
  MODIFY `IDRECUR` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT de la tabla `software`
--
ALTER TABLE `software`
  MODIFY `Idsoft` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT de la tabla `turno`
--
ALTER TABLE `turno`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `docente`
--
ALTER TABLE `docente`
  ADD CONSTRAINT `docente_ibfk_1` FOREIGN KEY (`AREA`) REFERENCES `area` (`idarea`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `recursos`
--
ALTER TABLE `recursos`
  ADD CONSTRAINT `recursos_ibfk_1` FOREIGN KEY (`SOFTWARE`) REFERENCES `software` (`idsoft`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
