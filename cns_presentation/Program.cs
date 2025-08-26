Console.WriteLine("Funciona");
//estas son las clases
public class Clientes
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public DateTime? FechaNacimiento { get; set; }
    public string? Documento { get; set; }
    public string? Correo { get; set; }
    public string? Telefono { get; set; }
    public int? Edad => FechaNacimiento.HasValue ? DateTime.Now.Year - FechaNacimiento.Value.Year : null;
}

public class EstadosHabitaciones
{
    public int Id { get; set; }
    public string? Descripcion { get; set; }
    public bool? PermiteReserva { get; set; }
}

public class TiposHabitaciones
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Descripcion { get; set; }
    public int? CapacidadMaxima { get; set; }
    public decimal? PrecioNoche { get; set; }
}

public class Habitaciones
{
    public int Id { get; set; }
    public int? TipoHabitacionId { get; set; }
    public TiposHabitaciones? Tipo { get; set; }
    public int? EstadoHabitacionId { get; set; }
    public EstadosHabitaciones? Estado { get; set; }
    public int? Numero { get; set; }
    public int? Piso { get; set; }
}

public class Servicios
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Descripcion { get; set; }
    public string? Categoria { get; set; }
    public decimal? Precio { get; set; }
}

public class EstadosReservas
{
    public int Id { get; set; }
    public string? Descripcion { get; set; }
}

public class Reservas
{
    public int Id { get; set; }
    public int? ClienteId { get; set; }
    public Clientes? Cliente { get; set; }
    public int? EstadoReservaId { get; set; }
    public EstadosReservas? Estado { get; set; }
    public DateTime? FechaReserva { get; set; }
    public DateTime? FechaIngreso { get; set; }
    public DateTime? FechaSalida { get; set; }
    public string? Observaciones { get; set; }
    public List<Acompanantes>? Acompanantes { get; set; }
    public List<DetallesReservas>? DetallesReserva { get; set; }
    public List<DetallesServicios>? DetallesServicio { get; set; }
}

public class Acompanantes
{
    public int Id { get; set; }
    public int? ReservaId { get; set; }
    public Reservas? Reserva { get; set; }
    public string? Nombre { get; set; }
    public DateTime? FechaNacimiento { get; set; }
    public string? Documento { get; set; }
    public int? Edad => FechaNacimiento.HasValue ? DateTime.Now.Year - FechaNacimiento.Value.Year : null;
}

public class DetallesReservas
{
    public int Id { get; set; }
    public int? ReservaId { get; set; }
    public Reservas? Reserva { get; set; }
    public int? HabitacionId { get; set; }
    public Habitaciones? Habitacion { get; set; }
    public int? CantidadNoches { get; set; }
    public decimal? PrecioNoche { get; set; }
    public decimal? Subtotal => CantidadNoches.HasValue && PrecioNoche.HasValue ? 
        CantidadNoches.Value * PrecioNoche.Value : null;
}

public class DetallesServicios
{
    public int Id { get; set; }
    public int? ReservaId { get; set; }
    public Reservas? Reserva { get; set; }
    public int? ServicioId { get; set; }
    public Servicios? Servicio { get; set; }
    public DateTime? Fecha { get; set; }
    public int? Cantidad { get; set; }
    public decimal? PrecioUnitario { get; set; }
    public decimal? Subtotal => Cantidad.HasValue && PrecioUnitario.HasValue ? 
        Cantidad.Value * PrecioUnitario.Value : null;
}

public class MetodosPago
{
    public int Id { get; set; }
    public string? Nombre { get; set; } 
    public string? Descripcion { get; set; }
    public bool? RequiereValidacion { get; set; }
    public bool? Activo { get; set; }
}

public class DetallesPago
{
    public int Id { get; set; }
    public int? FacturaId { get; set; }
    public Facturas? Factura { get; set; }
    public int? MetodoPagoId { get; set; }
    public MetodosPago? MetodoPago { get; set; }
    public decimal? Monto { get; set; }
    public string? Referencia { get; set; } 
    public DateTime? FechaPago { get; set; }
    public string? Estado { get; set; } 
    
    public string? UltimosDigitosTarjeta { get; set; }
    public string? TipoTarjeta { get; set; } 
}

public class Facturas
{
    public int Id { get; set; }
    public int? ReservaId { get; set; }
    public Reservas? Reserva { get; set; }
    public string? Codigo { get; set; }
    public DateTime? FechaEmision { get; set; }
    public DateTime? FechaPago { get; set; }
    public EstadosFacturas? Estado { get; set; }
    public decimal? Total { get; set; }

    public List<DetallesPago>? Pagos { get; set; }
    public List<DetallesReservas>? DetallesHabitacion { get; set; }
    public List<DetallesServicios>? DetallesServicio { get; set; }
}

public class EstadosFacturas
{
    public int Id { get; set; }
    public string? Descripcion { get; set; }
}