.data
	resultado: .ascii "Resultado: "
	
	string: .asciiz ""
	variaveisI: .asciiz "Variaveis Independentes: \n"
	espaco: .asciiz "\n"
	
	
.text
#-----------Le e imprime x,y,z-------------	
	jal lerNumero
	syscall
	move $s1, $v0
	
	jal lerNumero
	syscall	
	move $s2, $v0
	
	jal lerNumero
	syscall	
	move $s3, $v0
	
	la $a0, espaco
	jal imprimirString
	la $a0, variaveisI
	jal imprimirString
	
	jal imprimirNumero	
	move $a0, $s1
	syscall	
	
	la $a0, espaco
	jal imprimirString
	
	jal imprimirNumero	
	move $a0, $s2
	syscall
	
	la $a0, espaco
	jal imprimirString
			
	jal imprimirNumero	
	move $a0, $s3
	syscall	
	
	la $a0, espaco
	jal imprimirString
	
	#-------------- Começo da Equação -------------- 
	
	# 10.a.X^5
	move $t0, $s1
        move $t1, $s1
        li $t3, 5
        li $t2, 1
        li $t4, 10

        jal while
	
        jal imprimirNumero
        move $a0, $t1
        syscall
	move $t5, $t1
	la $a0, espaco
	jal imprimirString
	
	# 2by^4 
	move $t0, $s2
        move $t1, $s2
        li $t3, 4
        li $t2, 1
        li $t4, 2

        jal while

        jal imprimirNumero
        move $a0, $t1
        syscall
        move $t6, $t1
        la $a0, espaco
	jal imprimirString
        
        # 8.c.y^2
	move $t0, $s2
        move $t1, $s2
        li $t3, 2
        li $t2, 1
        li $t4, 8

        jal while

        jal imprimirNumero
        move $a0, $t1
        syscall
        move $t7, $t1 
        la $a0, espaco
	jal imprimirString
        
        # 6.d.z^3
	move $t0, $s3
        move $t1, $s3
        li $t3, 3
        li $t2, 1
        li $t4, 6

        jal while

        jal imprimirNumero
        move $a0, $t1
        syscall
        move $t8, $t1
        la $a0, espaco
	jal imprimirString
        
        # A B C D (Testes com valores 2, 4, 5)
        mul $t5, $t5, 2 # A = 2 320 * 2 v
        mul $t6, $t6, 3 # B = 4 512 * 3 v
        mul $t7, $t7, 4 # C = 6 128 * 4 v
        mul $t8, $t8, 5 # D = 8 750 * 5 v
        
        #Soma da equação :D
	sub $s4, $t5, $t6
	sub $s4, $s4, $t7
	add $s4, $s4, $t8
	
	la $a0, resultado
	jal imprimirString
	jal imprimirNumero
	move $a0, $s4
	syscall        
        
	
#----------Encerra-------------------------
	li $v0, 10
	syscall
	
while:
        addi $t2,$t2,1
        mul $t1,$t0,$t1
        blt $t2, $t3, while

        mul $t1, $t1, $t4
        jr $ra
	
.include "C:\Users\savio\OneDrive\Documentos\pasta segundo periodo si\assembly\teste.asm"