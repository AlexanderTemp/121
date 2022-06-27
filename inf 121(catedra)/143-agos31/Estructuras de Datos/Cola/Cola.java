package cola.numerico;

/**
 * Métodos para manejar una Cola Simple Circular
 * 
 * Código del libro:
 * 		Data Structures & Algorithms in Java 2nd Ed., Robert Lafore, 2003.
 * 
 * @version 1.00 15/08/11
 */
class Cola {
	private int MAXIMO;
	private long[] arreglo;
	private int inicio;
	private int fin;
	private int nroElementos;
	// --------------------------------------------------------------
	public Cola(int t) { // constructor
		MAXIMO = t;
		arreglo = new long[MAXIMO];
		inicio = 0;
		fin = -1;
		nroElementos = 0;
	}
	// --------------------------------------------------------------
	public void inserta(long e) { // inserta un elemento al final de la Cola
		if (!estaLlena()) {
			if (fin == MAXIMO - 1) // ¿fin = MAXIMO - 1?
				fin = -1;
			arreglo[++fin] = e; // incrementa fin y adiciona
			nroElementos++; // un elemento mas
		} else 
			System.out.println("No se puede insertar, la cola está llena.");
	}
	// --------------------------------------------------------------
	public long elimina() { // elimina un elemento del principio de la Cola
		long valor = Long.MIN_VALUE;
		if (!estaVacia()) {
			valor = arreglo[inicio++]; // obtiene el valor e incrementa inicio
			if (inicio == MAXIMO) // ¿inicio = MAXIMO?
				inicio = 0;
			nroElementos--; // un elemento menos
		} else
			System.out.println("No se puede eliminar, la cola está vacía.");
		return valor;
	}
	// --------------------------------------------------------------
	public long peek() { // obtiene el elemento del inicio de la Cola
		return arreglo[inicio];
	}
	// --------------------------------------------------------------
	public boolean estaVacia() { // verdad si la Cola esta vacía
		return (nroElementos == 0);
	}
	// --------------------------------------------------------------
	public boolean estaLlena() { // verdad si la Cola esta llena
		return (nroElementos == MAXIMO);
	}
	// --------------------------------------------------------------
	public int tamanio() { // número de elementos de la Cola
		return nroElementos;
	}
	// --------------------------------------------------------------
} // fin de la clase Cola

