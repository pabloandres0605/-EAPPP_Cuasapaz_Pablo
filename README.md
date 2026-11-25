# Gestor Rápido de Pedidos - Cafetería Universitaria

Aplicación de escritorio (Windows Forms, C#, .NET 8).

## Datos
- **Estudiante:** Pablo Andrés Cuasapaz Armijos
- **Asignatura:** ITID 543 - Diseño y Programación de Software
- **Docente:** Jose Naranjo

## Ejecución
Abrir `Prueba_B1_Diseño.sln` en Visual Studio y presionar **F5**. Formulario principal: `frmPedidoCafeteria`.

## Versiones
- **Clase:** tag `version_clase` (commit `683d7a3`, formulario `Form1`).
- **Completada en casa:** rama `main`.

## Eventos implementados
- **Load:** carga el catálogo y el estado inicial.
- **SelectedIndexChanged:** carga el producto elegido y habilita Quitar.
- **Validating:** exige que la cantidad sea un entero >= 1.
- **TextChanged:** habilita Agregar solo con producto y cantidad válida.
- **CheckedChanged:** recalcula el total al cambiar entrega o extras.
- **Click:** agrega, quita o limpia el pedido.

## Reglas de negocio
- Subtotal = Cantidad × Precio del catálogo.
- Total = Subtotales + entrega (+$0.50) + postre (+$1.00).
- No se agrega un ítem sin cliente, sin producto o con cantidad menor a 1.
- Cálculo centralizado en `ActualizarTotal()` (DRY).
