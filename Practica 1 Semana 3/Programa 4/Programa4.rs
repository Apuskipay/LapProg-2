use std::env;
use std::fs::File;
use std::io::{BufRead, BufReader};

fn main() -> std::io::Result<()>
{
	let ruta_archivo: Vec<String> = env:: args().collect();
	let documento = File :: open(&ruta_archivo[1]).expect("archivo no encontrado");
	let mut lector = BufReader :: new(documento);
	
	let mut linea = String::new();
	lector.read_line(&mut linea)?;
	
		if linea.len() < 10
		{
		println!("{}",linea);
		}
		else
		{
		eprintln!("El texto es mayor a 10 digitos");
		}
		Ok(())
	}