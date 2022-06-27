package lista.simple.iterador;
/**
 * Métodos para manejar una iterador de una lista enlazada simple.
 * 
 * Código del libro:
 * 		Data Structures & Algorithms in Java 2nd Ed., Robert Lafore, 2003.
 * 
 * @version 1.00 13/04/11
 */
class IteradorLista {
	private Nodo actual; // actual nodo
	private Nodo anterior; // anterior nodo
	private ListaEnlazada lista; // nuestra lista enlazada
	// --------------------------------------------------------------
	public IteradorLista(ListaEnlazada l) { // constructor
		lista = l;
		reset();
	}
	// --------------------------------------------------------------
	public void reset() { // actual está en 'primero'
		actual = lista.getPrimero();
		anterior = null;
	}
	// --------------------------------------------------------------
	public boolean estaAlFinal() { // verdad si actual está en el último nodo
		return (actual.sig == null);
	}
	// --------------------------------------------------------------
	public void sig() { // avanza actual y anterior al siguiente nodo
		anterior = actual;
		actual = actual.sig;
	}
	// --------------------------------------------------------------
	public Nodo getActual() { // obtiene direccion de actual
		return actual;
	}
	// --------------------------------------------------------------
	public void insertaDespues(int d) { // inserta nodo después del nodo actual
		Nodo nuevo = new Nodo(d);

		if (lista.estaVacia()) { // lista vacia
			lista.setPrimero(nuevo);
			actual = nuevo;
		} else { // no está vacia
			nuevo.sig = actual.sig;
			actual.sig = nuevo;
			sig(); // avanza al siguiente nodo
		}
	}
	// --------------------------------------------------------------
	public void insertaAntes(int d) { // inserta nodo antes del nodo actual
		Nodo nuevo = new Nodo(d);

		if (anterior == null) { // actual está al inicio de la lista (o la lista está vacía)
			nuevo.sig = lista.getPrimero();
			lista.setPrimero(nuevo);
			reset();
		} else { // no está al inicio de la lista
			nuevo.sig = anterior.sig;
			anterior.sig = nuevo;
			actual = nuevo;
		}
	}
	// --------------------------------------------------------------
	public int eliminaActual() { // elimina elemento de actual
		int valor = actual.dato;
		if (anterior == null) { // actual está al inicio de la lista (o la lista está vacia)
			lista.setPrimero(actual.sig);
			reset();
		} else { // no está al inicio de la lista
			anterior.sig = actual.sig;
			if (estaAlFinal())
				reset();
			else
				actual = actual.sig;
		}
		return valor;
	}
	// --------------------------------------------------------------
} // fin clase IteradorLista
