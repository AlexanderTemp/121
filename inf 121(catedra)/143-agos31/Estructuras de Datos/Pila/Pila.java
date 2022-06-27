package pila.numerico;
/**
 * Métodos para manejar una pila.
 * 
 * Código del libro:
 * 		Data Structures & Algorithms in Java 2nd Ed., Robert Lafore, 2003.
 *
 * @version 1.00 15/08/11
 */
class Pila {
	private int MAXIMO; // tamaño de la pila
	private long[] arreglo;
	private int top; // cima o parte superior de la pila
	// --------------------------------------------------------------
	public Pila(int t) { // constructor
		MAXIMO = t; // asigna el tamaño del arreglo
		arreglo = new long[MAXIMO]; // crea arreglo
		top = -1; // todavia no tiene elementos
	}
	// --------------------------------------------------------------
	public void inserta(long e) { // inserta un elemento en la cima de la pila
		if (!estaLlena())
			arreglo[++top] = e; // incrementa top, inserta elemento
		else
			System.out.println("No se puede insertar, la pila está llena.");
	}
	// --------------------------------------------------------------
	public long elimina() { // elimina un elemento de la cima de la pila
		long valor = Long.MIN_VALUE;
		if (!estaVacia())
			valor = arreglo[top--]; // retorna el elemento, decrementa el top
		else
			System.out.println("No se puede eliminar, la pila está vacía.");
		return valor;
	}
	// --------------------------------------------------------------
	public long peek() { // obtiene el elemento de la cima de la pila
		return arreglo[top];
	}
	// --------------------------------------------------------------
	public boolean estaVacia() { // verdad si la pila está vacía
		return (top == -1);
	}
	// --------------------------------------------------------------
	public boolean estaLlena() { // verdad si la pila está llena
		return (top == MAXIMO - 1);
	}
	// --------------------------------------------------------------
} // fin de la clase Pila
