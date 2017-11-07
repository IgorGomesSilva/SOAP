package exemplo.soap;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

import javax.ejb.Stateless;
import javax.jws.WebService;

@WebService
@Stateless
public class CalculadoraService {

	private String user = "igor";
	private String senha = "0102";
		
	//Valida Usuario e Senha.
	public boolean validarUsuarioSenha(String user, String senha){
		
		if (user.equalsIgnoreCase(this.user) && senha.equals(senha)){
			return true;
		}
		return false;
	}
	
	
	//Gera Valores.
	public List<Integer> gerarValores(){
		List<Integer> inteiros = new ArrayList();
		Random r = new Random();
		for (int i = 0; i <= 10; i++){
			inteiros.add(i * r.nextInt(10));
		}
		return inteiros;
	}
}
