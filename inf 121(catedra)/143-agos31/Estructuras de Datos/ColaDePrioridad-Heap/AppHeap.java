package heaps;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
/**
 * Aplicación de Monticulo
 * 
 * Código del libro:
 * 		Data Structures & Algorithms in Java 2nd Ed., Robert Lafore, 2003.
 * 
 * @version 1.00 15/08/2011
 */
class AppHeap {
	public static void main(String[] args) throws IOException {
		int valor, valor2;
		Heap elMonticulo = new Heap(31); // genera un monticulo; de tamaño 31
		boolean exito;

//		elMonticulo.inserta(70); // inserta 10 elementos
//		elMonticulo.inserta(40);
//		elMonticulo.inserta(50);
//		elMonticulo.inserta(20);
//		elMonticulo.inserta(60);
//		elMonticulo.inserta(100);
//		elMonticulo.inserta(80);
//		elMonticulo.inserta(30);
//		elMonticulo.inserta(10);
//		elMonticulo.inserta(90);

		while (true) // hasta [Ctrl]-[C]
		{
			System.out.print("Ingrese primera letra de: ");
			System.out.print("[m]ostrar, [i]nsertar, [e]liminar, [c]ambiar: ");
			int letra = getChar();
			switch (letra) {
			case 'm': // mostrar
				elMonticulo.despliegaHeap();
				break;
			case 'i': // insertar
				System.out.print("Ingrese valor a insertar: ");
				valor = getInt();
				exito = elMonticulo.inserta(valor);
				if (!exito)
					System.out.println("No puede insertar; monticulo lleno");
				break;
			case 'e': // eliminar
				if (!elMonticulo.estaVacia())
					elMonticulo.elimina();
				else
					System.out.println("No puede eliminar; monticulo vacio");
				break;
			case 'c': // cambiar
				System.out.print("Ingrese indice actual del elemento: ");
				valor = getInt();
				System.out.print("Ingrese nueva clave: ");
				valor2 = getInt();
				exito = elMonticulo.cambia(valor, valor2);
				if (!exito)
					System.out.println("Indice no válido");
				break;
			default:
				System.out.println("Letra no valida\n");
			} // fin switch
		} // fin while
	} // fin main()
	// -------------------------------------------------------------

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
} // fin de la clase AppHeap
// //////////////////////////////////////////////////////////////