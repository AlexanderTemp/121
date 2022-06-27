package lista.simple.iterador;

import java.io.*;
/**
 * Aplicación de un iterador de una lista enlazada simple.
 * 
 * Código del libro:
 * 		Data Structures & Algorithms in Java 2nd Ed., Robert Lafore, 2003.
 * 
 * @version 1.00 13/04/11
 */
class AppIterador {
	public static void main(String[] args) throws IOException {
		ListaEnlazada laLista = new ListaEnlazada(); // nueva lista
		IteradorLista it = laLista.getIterador(); // nuevo iterador
		int value;

		it.insertaDespues(20); // adicionamos elementos
		it.insertaDespues(40);
		it.insertaDespues(80);
		it.insertaAntes(60);

		while (true) {
			System.out.print("Ingrese primera letra de [m]uestra, [r]eset, ");
			System.out.print("[s]iguiente, [o]btiene, [a]ntes, [d]espues, [e]limina, [f]inaliza: ");
			System.out.flush();
			int opcion = getChar(); // obtiene opción
			switch (opcion) {
			case 'm': // muestra la lista
				if (!laLista.estaVacia())
					laLista.despliegaLista();
				else
					System.out.println("La lista está vacia");
				break;
			case 'r': // reset (actual toma la dirección de primero)
				it.reset();
				break;
			case 's': // avanza al siguiente nodo
				if (!laLista.estaVacia() && !it.estaAlFinal())
					it.sig();
				else
					System.out.println("No puede ir al siguiente nodo");
				break;
			case 'o': // obtiene actual elemento
				if (!laLista.estaVacia()) {
					value = it.getActual().dato;
					System.out.println("Retorna " + value);
				} else
					System.out.println("La lista está vacia");
				break;
			case 'a': // inserta antes de actual
				System.out.print("Ingrese valor a insertar: ");
				System.out.flush();
				value = getInt();
				it.insertaAntes(value);
				break;
			case 'd': // inserta después de actual
				System.out.print("Ingrese valor a insertar: ");
				System.out.flush();
				value = getInt();
				it.insertaDespues(value);
				break;
			case 'e': // elimina elemento donde apunta actual
				if (!laLista.estaVacia()) {
					value = it.eliminaActual();
					System.out.println("Elimina " + value);
				} else
					System.out.println("No puede eliminar");
				break;
			case 'f': // finaliza
				return;
			default:
				System.out.println("Entrada no valida");
			} // fin switch
		} // fin while
	} // fin main()
	// --------------------------------------------------------------

	public static String getString() throws IOException {
		InputStreamReader isr = new InputStreamReader(System.in);
		BufferedReader br = new BufferedReader(isr);
		String s = br.readLine();
		return s;
	}

	// -------------------------------------------------------------
	public static char getChar() throws IOException {
		String s = getString();
		return s.charAt(0);
	}

	// -------------------------------------------------------------
	public static int getInt() throws IOException {
		String s = getString();
		return Integer.parseInt(s);
	}
	// -------------------------------------------------------------
} // fin clase AppIterador
