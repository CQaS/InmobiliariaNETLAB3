-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 03-11-2021 a las 01:12:25
-- Versión del servidor: 10.4.17-MariaDB
-- Versión de PHP: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `inmobiliaria_net`
--

DELIMITER $$
--
-- Funciones
--
CREATE DEFINER=`root`@`localhost` FUNCTION `Maxi` (`ultimo` INT) RETURNS INT(11) BEGIN
    DECLARE ultimopago int default 1;
    
    SELECT IFNULL(max(num_pago +1), 1)
    INTO ultimopago
    FROM pagos 
    WHERE ContratoId = ultimo;
    
    RETURN ultimopago;
	
END$$

CREATE DEFINER=`root`@`localhost` FUNCTION `Multa` (`m` INT) RETURNS INT(11) BEGIN 
DECLARE multon int default -1;

SELECT (( SELECT TIMESTAMPDIFF(MONTH, Curdate(), fe_fin) as Meses FROM contrato WHERE id = m) /(SELECT TIMESTAMPDIFF(MONTH, fe_ini, fe_fin) as Meses FROM contrato WHERE id = m))
INTO multon
FROM contrato 
WHERE id = m;

IF multon > 0.5 THEN
SET multon = 1;
ELSEIF multon < 0.5 THEN
SET multon = 2;
END IF;
    
RETURN multon;

END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `contrato`
--

CREATE TABLE `contrato` (
  `id` int(5) NOT NULL,
  `fe_ini` date NOT NULL,
  `fe_fin` date NOT NULL,
  `monto` int(11) NOT NULL,
  `id_inmueble` int(10) NOT NULL,
  `id_inquilino` int(10) NOT NULL,
  `estado` int(5) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `contrato`
--

INSERT INTO `contrato` (`id`, `fe_ini`, `fe_fin`, `monto`, `id_inmueble`, `id_inquilino`, `estado`) VALUES
(1, '2021-04-15', '2021-12-31', 960000, 1, 3, 1),
(2, '2021-04-01', '2022-12-31', 50000, 3, 8, 1),
(3, '2021-04-21', '2021-10-21', 50000, 4, 8, 1),
(4, '2021-12-17', '2022-12-31', 205000, 2, 7, 1),
(5, '2021-10-15', '2021-11-15', 44050, 9, 8, 1),
(6, '2021-01-01', '2021-07-01', 34050, 7, 7, 1),
(9, '2021-04-20', '2021-09-30', 506667, 6, 10, 1),
(10, '2021-04-03', '2022-12-31', 200000, 11, 9, 1),
(11, '2021-04-23', '2021-12-30', 35500, 8, 3, 1),
(12, '2021-01-01', '2021-05-31', 8000, 5, 9, 1),
(13, '2021-11-02', '2022-11-30', 89900, 17, 13, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inmueble`
--

CREATE TABLE `inmueble` (
  `id_Inmu` int(10) NOT NULL,
  `direccion_in` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `uso` varchar(10) COLLATE utf8_spanish_ci NOT NULL,
  `tipo` varchar(15) COLLATE utf8_spanish_ci NOT NULL,
  `ambientes` int(5) NOT NULL,
  `precio` int(10) NOT NULL,
  `id_propietario` int(5) NOT NULL,
  `estado` int(5) NOT NULL DEFAULT 1,
  `foto` varchar(250) COLLATE utf8_spanish_ci NOT NULL,
  `disponible` int(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `inmueble`
--

INSERT INTO `inmueble` (`id_Inmu`, `direccion_in`, `uso`, `tipo`, `ambientes`, `precio`, `id_propietario`, `estado`, `foto`, `disponible`) VALUES
(1, 'El cipres 100', 'temporal', 'Hogar', 4, 8000, 4, 1, '/img/fotos1/frente.jpg', 1),
(2, 'Av Mercau 250', 'residencia', 'departamento', 4, 30000, 8, 0, '/img/fotos2/frente.jpg', 1),
(3, 'Los Incas 3444', 'Cabaña', 'Hogar', 5, 12500, 4, 1, '/img/fotos3/frente.jpg', 1),
(4, 'Jkoslay - Ruta 20', 'Deportivo', 'Canchas', 6, 17000, 6, 1, '/img/fotos4/frente.jpg', 1),
(5, 'Barranca Colorada', 'Cabaña', 'Hogar', 5, 25000, 11, 1, '/img/fotos5/frente.jpg', 1),
(6, 'Cerro Aspero', 'Deportivo', 'Club', 10, 300000, 9, 1, '/img/fotos6/frente.jpg', 1),
(7, 'Chumamaya', 'Familiar', 'Chalet', 7, 50000, 10, 1, '\\img/fotos10\\Inmueble_10.jpg', 1),
(8, 'Chumamaya lote5', 'Cabaña', 'Hogar', 5, 45000, 4, 1, '/img/fotos4/Inmueble_4.jpg', 1),
(10, 'Piedra Blanca Este', 'Social', 'Club', 8, 100000, 12, 1, '/img/fotos12\\Inmueble_19_04_2021.jpg', 1),
(11, 'Ptro. Becerra 210', 'Familiar', 'Dpto', 4, 46000, 12, 1, '/img/fotos12\\Inmueble_19_04_202107_44_48.jpg', 1),
(12, 'Cipres 300', 'Familiar', 'Dpto', 3, 45000, 3, 1, '/img/fotos3\\Inmueble_20_10_202107_46_03.jpg', 1),
(13, 'Los Alerces 33', 'Familiar', 'Dpto', 5, 67022, 5, 1, '/img/fotos5\\Inmueble_20_10_202107_47_24.jpg', 1),
(14, 'Pta. Conti 1700', 'Familiar', 'Casa', 6, 146900, 8, 1, '/img/fotos8\\Inmueble_20_10_202107_48_59.jpg', 1),
(15, 'Cañada Negra 5670', 'Familiar', 'Cabaña', 3, 74000, 13, 1, '/img/fotos13\\Inmueble_20_10_202107_50_43.jpg', 1),
(16, 'Pringles 1201 PB', 'Salon de B', 'Comercio', 2, 34000, 15, 1, '/img/fotos15\\Inmueble_25_10_202108_37_47.jpg', 1),
(17, 'Peatonal Quinteros', 'Dptos', 'Oficinas', 4, 93000, 4, 1, '/img/fotos4\\Inmueble_02_11_202110_23_50.jpg', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inquilinos`
--

CREATE TABLE `inquilinos` (
  `id` int(10) NOT NULL,
  `Dni` int(50) NOT NULL,
  `Nombre` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `mail` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `direccion` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `tel_inquilino` int(20) NOT NULL,
  `lugarTrabajo` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `nom_garante` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `dni_garante` int(15) NOT NULL,
  `tel_garante` int(20) NOT NULL,
  `estado` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `inquilinos`
--

INSERT INTO `inquilinos` (`id`, `Dni`, `Nombre`, `mail`, `direccion`, `tel_inquilino`, `lugarTrabajo`, `nom_garante`, `dni_garante`, `tel_garante`, `estado`) VALUES
(3, 22457884, 'Marcial Jacinto', 'marcial@mail.com', 'Nueva Galia sur', 482555, 'Kimberly', 'Juan Zalsedo', 7849837, 23344657, 1),
(5, 123456, 'Mary Campos', 'mary@mail.com', 'Rios de los Sauces - Cba', 9735723, 'Jkoslay Inc.', 'Ana Roganovich', 44545453, 54532234, 1),
(7, 1928374, 'Agostina Argento', 'argento@mail.com', 'Albardon - SJ', 345632, 'Bodegas INCA', 'Clarisa Camargo', 9999292, 3453748, 1),
(8, 34783759, 'Alex Baldez', 'alex@gmail.com', '500 Sur', 38756838, 'Autonomo', 'Leo Baldez', 56456456, 456646456, 1),
(9, 8658782, 'Luisa Devia', 'devia@mail.com', 'Mundial 78', 47565, 'Artesanias LU', 'Lucas Arrieta', 67858, 247843, 1),
(10, 3476845, 'Paolo DoSanto', 'paolo@mail.com', 'Brazil', 836823, 'Playa', 'Andreina Leiva', 7687387, 7474738, 1),
(11, 646799, 'Jose Arnaldo', 'arnaldo@mail.com', 'Los quebrachos 32', 6473895, 'Antie', 'Lucas Soliz', 77583893, 46384739, 1),
(12, 658748, 'Frida Duarte', 'duarte@mail.com', 'B170 M51 C47', 6387384, 'UNSL', 'Goyo Duarte', 7384938, 463848, 1),
(13, 6363636, 'Martinez Marcela', 'marce@mail.com', 'Los incas 22', 22334456, 'Super Top', 'Martinez Edgar', 757576, 63637, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos`
--

CREATE TABLE `pagos` (
  `id` int(10) NOT NULL,
  `num_pago` int(50) NOT NULL,
  `fecha` date NOT NULL,
  `importe` decimal(15,0) NOT NULL,
  `ContratoId` int(10) NOT NULL,
  `estado` int(5) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `pagos`
--

INSERT INTO `pagos` (`id`, `num_pago`, `fecha`, `importe`, `ContratoId`, `estado`) VALUES
(14, 1, '2021-09-19', '63000', 11, 1),
(15, 2, '2021-10-19', '34050', 11, 1),
(16, 1, '2021-10-05', '50000', 3, 1),
(17, 1, '2021-10-05', '960000', 1, 1),
(18, 2, '2021-11-05', '960000', 1, 1),
(19, 2, '2021-11-05', '50000', 3, 1),
(20, 1, '2021-07-01', '50000', 2, 1),
(21, 2, '2021-08-01', '50000', 2, 1),
(22, 3, '2021-12-01', '960000', 1, 1),
(23, 3, '2021-12-01', '35500', 11, 1),
(24, 4, '2022-01-01', '960000', 1, 1),
(25, 4, '2022-01-01', '35500', 11, 1),
(26, 3, '2021-12-01', '50000', 2, 1),
(27, 4, '2022-01-01', '50000', 2, 1),
(28, 1, '2021-11-02', '89900', 13, 1),
(29, 2, '2021-12-02', '89900', 13, 1),
(30, 3, '2022-01-02', '89900', 13, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `propietarios`
--

CREATE TABLE `propietarios` (
  `id` int(5) NOT NULL,
  `Nombre` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `Dni` int(20) NOT NULL,
  `Direccion` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `tel` int(20) NOT NULL,
  `Email` varchar(200) COLLATE utf8_spanish_ci NOT NULL DEFAULT 'mail@mail.com',
  `Avatar` varchar(100) COLLATE utf8_spanish_ci NOT NULL DEFAULT '/img/default.jpg',
  `Clave` varchar(150) COLLATE utf8_spanish_ci NOT NULL DEFAULT 'Od5l8kFX8vwvOF5BPAZjFy6qbs/5m9WgQzPkKL1TqA8=',
  `estado` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `propietarios`
--

INSERT INTO `propietarios` (`id`, `Nombre`, `Dni`, `Direccion`, `tel`, `Email`, `Avatar`, `Clave`, `estado`) VALUES
(3, 'Zabala Nelida', 1168476, 'La Punta', 784392, 'zabala@mail.com', '/img/default.jpg', 'Od5l8kFX8vwvOF5BPAZjFy6qbs/5m9WgQzPkKL1TqA8=', 1),
(4, 'Romagnolli Antonella', 6644667, 'San Luis Cap', 33451144, 'romagnolli@mail.com', '/img/avatars\\propietarios/romagnoli.jpg', 'Od5l8kFX8vwvOF5BPAZjFy6qbs/5m9WgQzPkKL1TqA8=', 1),
(5, 'Faustino Sosa', 65746574, 'Los Cocos', 256348, 'sosa@mail.com', '/img/default.jpg', 'Od5l8kFX8vwvOF5BPAZjFy6qbs/5m9WgQzPkKL1TqA8=', 1),
(6, 'Gustavo Bogado', 5181575, 'Cortaderas', 837463, 'bogado@mail.com', '/img/default.jpg', 'Od5l8kFX8vwvOF5BPAZjFy6qbs/5m9WgQzPkKL1TqA8=', 1),
(8, 'leonel baldez', 80956675, '500 Sur m171 c1', 9999999, 'baldez@mail.com', '/img/default.jpg', 'Od5l8kFX8vwvOF5BPAZjFy6qbs/5m9WgQzPkKL1TqA8=', 1),
(9, 'fulano mengano', 26736788, 'juana koslay', 4764487, 'mengano@mail.com', '/img/default.jpg', 'Od5l8kFX8vwvOF5BPAZjFy6qbs/5m9WgQzPkKL1TqA8=', 1),
(10, 'Molina Campos', 789, 'La Pampa', 35189345, 'campos@mail.com', '/img/default.jpg', 'Od5l8kFX8vwvOF5BPAZjFy6qbs/5m9WgQzPkKL1TqA8=', 1),
(11, 'Teodoro Albornoz', 97364654, 'Pampa de Achala', 2489467, 'albornoz@mail.com', '/img/default.jpg', 'Od5l8kFX8vwvOF5BPAZjFy6qbs/5m9WgQzPkKL1TqA8=', 1),
(12, 'Marina Bustos', 675839, 'Av del Sol 101', 573839, 'bustos@mail.com', '/img/default.jpg', 'Od5l8kFX8vwvOF5BPAZjFy6qbs/5m9WgQzPkKL1TqA8=', 1),
(13, 'Silvina Navarro', 9374658, 'Los teros s/n', 434393, 'silvina@mail.com', '/img/default.jpg', 'Od5l8kFX8vwvOF5BPAZjFy6qbs/5m9WgQzPkKL1TqA8=', 1),
(15, 'Amaya sonia', 343434, 'Pringles 1201 piso 1', 55445544, 'amaya@mail.com', '/img/default.jpg', 'dCLr3UHlP+PxICzwgKxGBC+drOn3vP3Apcur5I77JXI=', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(10) NOT NULL,
  `Nombre` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `Apellido` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `Avatar` varchar(50) COLLATE utf8_spanish_ci NOT NULL DEFAULT '/img/default.jpg',
  `Mail` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `Clave` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `pregunta` varchar(150) COLLATE utf8_spanish_ci NOT NULL,
  `Rol` int(10) NOT NULL,
  `estado` int(5) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `Nombre`, `Apellido`, `Avatar`, `Mail`, `Clave`, `pregunta`, `Rol`, `estado`) VALUES
(2, 'Admin', 'Admin', '/img/avatars/usuarios/admin.jpg', 'admin@mail.com', 'Od5l8kFX8vwvOF5BPAZjFy6qbs/5m9WgQzPkKL1TqA8=', 'admin', 1, 1),
(8, 'Yanina', 'Sarmiento', '/img/avatars/usuarios/avatar_yani@mail.com.jpg', 'yani@mail.com', 'O/GNVCJ4WQOmY9isoyQQcW0RuNMdL2oZjHij8JUvyh4=', 'yani', 2, 1),
(9, 'Lorenzo', 'Rosales', '/img/default.jpg', 'rosales@mail.com', 'xgoKeIJD+VeM6HIFoQArXwHk/grZSiA1bY5N79w2RPQ=', 'rosales', 2, 1),
(10, 'Dante', 'Gaudes', '/img/avatars/usuarios/avatar_gaude@mail.com.jpg', 'gaude@mail.com', '1YTD46gt2Z3a7nHRAD1xOuveWcFwr6S74ase1jkD1Fw=', 'gaude', 2, 1),
(11, 'Ramoncito', 'Alba', '/img/avatars/usuarios/avatar_alba@mail.com.jpg', 'alba@mail.com', 'SM7sXEHBQIopzhSXLc7G8ZcIbwqY/ueyo5rS8+R6MCM=', 'alba', 2, 1),
(12, 'Mara', 'Cuellos', '/img/avatars/usuarios/admin.jpg', 'cuello@mail.com', 'Od5l8kFX8vwvOF5BPAZjFy6qbs/5m9WgQzPkKL1TqA8=', 'cuello', 2, 1),
(13, 'Walter', 'Oviedo', '/img/avatars/usuarios/avatar_aviedo@mail.com.jpg', 'oviedo@mail.com', 'co4IURqmAES3gIHty4sZ8xIeewraNFCnDQYlnZLS5Ds=', 'oviedo', 2, 1),
(14, 'Roxi', 'Almeida', '/img/avatars/usuarios/avatar_almeida@mail.com.jpg', 'almeida@mail.com', 'qIPeiKr8XPMuu/eJLiUP9QmXDwbQg1zxzG0tZ2lUaZM=', 'almeida', 1, 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `contrato`
--
ALTER TABLE `contrato`
  ADD PRIMARY KEY (`id`),
  ADD KEY `in_i` (`id_inquilino`);

--
-- Indices de la tabla `inmueble`
--
ALTER TABLE `inmueble`
  ADD PRIMARY KEY (`id_Inmu`),
  ADD KEY `i_p` (`id_propietario`);

--
-- Indices de la tabla `inquilinos`
--
ALTER TABLE `inquilinos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `pagos`
--
ALTER TABLE `pagos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `p_c` (`ContratoId`);

--
-- Indices de la tabla `propietarios`
--
ALTER TABLE `propietarios`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `contrato`
--
ALTER TABLE `contrato`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `inmueble`
--
ALTER TABLE `inmueble`
  MODIFY `id_Inmu` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT de la tabla `inquilinos`
--
ALTER TABLE `inquilinos`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `pagos`
--
ALTER TABLE `pagos`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT de la tabla `propietarios`
--
ALTER TABLE `propietarios`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `contrato`
--
ALTER TABLE `contrato`
  ADD CONSTRAINT `in_i` FOREIGN KEY (`id_inquilino`) REFERENCES `inquilinos` (`id`);

--
-- Filtros para la tabla `inmueble`
--
ALTER TABLE `inmueble`
  ADD CONSTRAINT `i_p` FOREIGN KEY (`id_propietario`) REFERENCES `propietarios` (`id`);

--
-- Filtros para la tabla `pagos`
--
ALTER TABLE `pagos`
  ADD CONSTRAINT `p_c` FOREIGN KEY (`ContratoId`) REFERENCES `contrato` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
