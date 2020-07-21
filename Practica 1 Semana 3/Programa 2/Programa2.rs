use std::env;

fn main(){
let args: Vec<String> = env::args ().collect();

let nombre= &args[1];

println!("Hello {}!", nombre);

}