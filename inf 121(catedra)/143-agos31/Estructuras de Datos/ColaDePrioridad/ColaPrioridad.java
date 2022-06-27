package colaprioridad;

/**
 * Métodos para manejar una Cola de Prioridad
 * 
 * Código del libro:
 * 		Data Structures & Algorithms in Java 2nd Ed., Robert Lafore, 2003.
 *
 * @version 1.00 21/08/11
 */
class ColaPrioridad {
	// arreglo ordenado, desde el máximo en 0 hasta el mínimo en nroElementos-1
	private int MAXIMO;
	private long[] arreglo;
	private int nroElementos;
	// -------------------------------------------------------------
	public ColaPrioridad(int t) { // constructor
		MAXIMO = t;
		arreglo = new long[MAXIMO];
		nroElementos = 0;
	}
	// -------------------------------------------------------------
	public void inserta(long e) { // inserta un elemento
		int j;
		if (!estaLlena()) {
			if (nroElementos == 0) // si no hay elementos,
				arreglo[nroElementos++] = e; // se inserta en la posición 0
			else { // si hay elementos,
				for (j = nroElementos - 1; j >= 0; j--) { // inicia desde el final,
					if (e > arreglo[j]) // si el nuevo elemento es mayor,
						arreglo[j + 1] = arreglo[j]; // se desplaza los elementos
					else // si es menor,
						break; // sale del desplazamiento
				} // fin for
				arreglo[j + 1] = e; // inserta el nuevo elemento
				nroElementos++;
			} // fin else (nroElementos > 0)
		} else 
			System.out.println("No se puede insertar, la cola está llena.");
	} // fin adiciona()
	// -------------------------------------------------------------
	public long elimina() { // elimina el mínimo elemento
		long valor = Long.MIN_VALUE;
		if (!estaVacia()) {
			valor = arreglo[--nroElementos];
		} else
			System.out.println("No se puede eliminar, la cola está vacia.");
		return valor;
	}
	// -------------------------------------------------------------
	public long peek() { // obtiene el mínimo elemento
		return arreglo[nroElementos - 1];
	}
	// -------------------------------------------------------------
	public boolean estaVacia() { // verdad si la cola esta vacía
		return (nroElementos == 0);
	}
	// -------------------------------------------------------------
	public boolean estaLlena() { // verdad si la cola esta llena
		return (nroElementos == MAXIMO);
	}
	// -------------------------------------------------------------
} // fin de la clase ColaPrioridad
