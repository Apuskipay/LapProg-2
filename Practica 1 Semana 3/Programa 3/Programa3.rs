use std::env;
use std::fs::File;
use std::io::{BufReader, BufRead};

fn main(){
  let ruta_archivo:Vec<String> = env::args().collect();
  let documento = File::open(&ruta_archivo[1]).unwrap();
  let lector = BufReader::new(documento);
  
  for(_indice, lineas) in lector.lines().enumerate(){
    let lectura = lineas.unwrap();
	println!("{}", lectura);
  }
}