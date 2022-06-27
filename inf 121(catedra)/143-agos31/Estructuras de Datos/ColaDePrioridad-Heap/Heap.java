package heaps;

/**
 * Clase Heap.
 * 
 * C�digo del libro:
 * 		Data Structures & Algorithms in Java 2nd Ed., Robert Lafore, 2003.
 *
 * @version 1.00 15/08/11
 */

class Heap {
	private Nodo[] arregloHeap;
	private int maxTama�o; 		// tama�o del arreglo
	private int tama�oActual; 	// n�mero de nodos del arreglo
	// -------------------------------------------------------------
	public Heap(int max) { // constructor
		maxTama�o = max;
		tama�oActual = 0;
		arregloHeap = new Nodo[maxTama�o]; // crea arreglo
	}
	// -------------------------------------------------------------
	public boolean estaVacia() {
		return tama�oActual == 0;
	}
	// -------------------------------------------------------------
	public boolean inserta(int clave) {
		if (tama�oActual == maxTama�o)
			return false;
		Nodo nuevoNodo = new Nodo(clave);
		arregloHeap[tama�oActual] = nuevoNodo;
		acomodaArriba(tama�oActual++);
		return true;
	} // fin inserta()
	// -------------------------------------------------------------
	public void acomodaArriba(int indice) {
		int padre = (indice - 1) / 2;
		Nodo abajo = arregloHeap[indice];

		while (indice > 0 && arregloHeap[padre].getClave() < abajo.getClave()) {
			arregloHeap[indice] = arregloHeap[padre]; // mueve hacia abajo
			indice = padre;
			padre = (padre - 1) / 2;
		} // fin while
		arregloHeap[indice] = abajo;
	} // fin acomodaArriba()
	// -------------------------------------------------------------
	public Nodo elimina() { // elimina elemento con la clave m�xima
		// (se asume que la lista no est� vacia)
		Nodo raiz = arregloHeap[0];
		arregloHeap[0] = arregloHeap[--tama�oActual];
		acomodaAbajo(0);
		return raiz;
	} // fin elimina()
	// -------------------------------------------------------------
	public void acomodaAbajo(int indice) {
		int hijoMayor;
		Nodo cima = arregloHeap[indice]; // guarda ra�z
		while (indice < tama�oActual / 2) // mientras que el nodo tenga
		{ 								  // al menos un hijo,
			int hijoIzquierdo = 2 * indice + 1;
			int hijoDerecho = hijoIzquierdo + 1;
			// encuentra el hijo mayor
			if (hijoDerecho < tama�oActual && // (�existe hijoDerecho?)
					arregloHeap[hijoIzquierdo].getClave() < arregloHeap[hijoDerecho]
							.getClave())
				hijoMayor = hijoDerecho;
			else
				hijoMayor = hijoIzquierdo;
			// �cima >= hijoMayor?
			if (cima.getClave() >= arregloHeap[hijoMayor].getClave())
				break;
			// desplaza hijo arriba
			arregloHeap[indice] = arregloHeap[hijoMayor];
			indice = hijoMayor; // baja
		} // end while
		arregloHeap[indice] = cima; // raiz a indice
	} // end acomodaAbajo()
	// -------------------------------------------------------------
	public boolean cambia(int indice, int nuevoValor) {
		if (indice < 0 || indice >= tama�oActual)
			return false;
		int antValor = arregloHeap[indice].getClave(); // guarda ant
		arregloHeap[indice].setClave(nuevoValor); // cambia al nuevo

		if (antValor < nuevoValor)
			acomodaArriba(indice); // acomoda arriba
		else
			acomodaAbajo(indice); // acomoda abajo
		return true;
	} // fin cambia()
	// -------------------------------------------------------------
	public void despliegaHeap() {
		System.out.print("arregloHeap: "); // formato arreglo
		for (int m = 0; m < tama�oActual; m++)
			if (arregloHeap[m] != null)
				System.out.print(arregloHeap[m] + " ");
			else
				System.out.print("-- ");
		System.out.println();
		// formato heap
		int espacios = 32;
		int elementosPorFila = 1;
		int columna = 0;
		int j = 0; // actual elemento
		String puntos = "...............................";
		System.out.println(puntos + puntos); // linea de punto de arriba

		while (tama�oActual > 0) // para cada elemento del heap
		{
			if (columna == 0) // �primer elemento de la fila?
				for (int k = 0; k < espacios; k++)
					// espacios preliminares
					System.out.print(' ');
			// despliega elemento
			System.out.print(arregloHeap[j]);

			if (++j == tama�oActual) // �realizo?
				break;

			if (++columna == elementosPorFila) // �fin de la fila?
			{
				espacios /= 2; // mitad para los espacios
				elementosPorFila *= 2; // doble para los elementos
				columna = 0; // empieza de nuevo
				System.out.println(); // nueva fila
			} else
				// siguiente elemento de la fila
				for (int k = 0; k < espacios * 2 - 2; k++)
					System.out.print(' '); // espacios intermedios
		} // fin for
		System.out.println("\n" + puntos + puntos); // linea de puntos de abajo
	} // fin despliegaHeap()
	// -------------------------------------------------------------
	@Override
	public String toString() {
		String s = "";
		for (int i = 0; i < tama�oActual; i++)
			s = s + arregloHeap[i];
		return s;
	}
	// -------------------------------------------------------------
} // fin de la clase Heap
