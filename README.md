# TrabajoPracticoIntegrador3
Trabajo practico integrador N°3 de la materia Programación Orientada a objetos de la carrera Analista Programador UAI.
Nos solicitan crear un programa que implemente las siguientes interfaces:
1. IComparer
2. ICloneable
3. IEnumerable
4. IEnumerator
El programa debe administrar una lista de productos. Cada producto posee los 
siguinetes datos:
Id(*) string
Descripción string
Precio decimal
Strock int
(*) El formato del Id se debe validar y el formato es el siguiente:
001-L01-OP200-02/10/2018
Dónde:
001 Es el código de producto
L01 Número de línea
OP200 Código de operador
01/10/2018 Fecha de fabricación
Los producto se deben mostrar en una grilla. Construya la posibilidad de agregar, borrar 
y modificar productos. Las siguientes operaciones se deben realizar implementando 
interfaces.
Los productos se deben poder ordenar por Id y precio de manera ascendente y
descendiente.
Se debe poder clonar el producto seleccionado en la grilla y mostrar su estado en cajas 
de texto. Demostrar que puede modificar el estado del objeto clonado y no afecta el 
original.
El producto puede ser iterado por un foreach y debe mostrar en cada iteración una de 
las partes del Id
