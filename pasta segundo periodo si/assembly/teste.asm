.text
imprimirString:
	li $v0, 4
	syscall	
	jr $ra
	
imprimirNumero:
	li $v0, 1
	jr $ra
	
lerString:
	li $v0, 8
	la $a0, string
	la $a1, 25
	jr $ra
	
lerNumero:
	li $v0, 5
	jr $ra
	
	
