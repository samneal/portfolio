TITLE Chapter 5 Exercise 2              (ch05_02.asm)

Comment !
Description:Write a program that uses a loop to input ten
signed 32-bit integers from the user, stores the integers
in an array, and redisplays the integers.
!
INCLUDE Irvine32.inc
COUNT = 0
COUNT2 = 4
.data
str1 BYTE "Enter Salesperson ID  ",0
str3 BYTE "Enter Amt Sold ",0
str4 BYTE "Enter Product Number (1-5) ",0
str2 BYTE "Redisplaying the integers: ",0dh,0ah,0

sales1 BYTE "SalesPerson 1 Data:  ",0
sales2 BYTE "SalesPerson 2 Data:  ",0
sales3 BYTE "SalesPerson 3 Data:  ",0
sales4 BYTE "SalesPerson 4 Data:  ",0
sales5 BYTE "                       p1 p2 p3 p4 p5  T",0

tot1 BYTE "Sales1 Total: ",0
tot2 BYTE "Sales2 Total: ",0
tot3 BYTE "Sales3 Total: ",0
tot4 BYTE "Sales4 Total: ",0

space BYTE " ",0


salesArray SDWORD 1,2,3,4
totalsArray SDWORD 0,0
productsArray SDWORD 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0

.code
main PROC

; Input integers from user

	mov ecx,5
     mov ebx,COUNT2
	
     mov edi,OFFSET productsArray
     mov esi, 3
L1:	
     mov edx,OFFSET str1
     call WriteString		; display prompt
     call Crlf
     call ReadInt		; read int from user
     dec eax

     cmp eax, -2
     je B1

     cmp eax, 0
     je C9

     cmp eax, 1
     je C1

     cmp eax, 2
     je C2

     cmp eax, 3
     je C3

     C3:
     add eax, 19
     
     C2:
     add eax, 19
    
        
     C1:
     add eax, 19
     
     C9:     
	mov  ecx,eax		; store in array
	
     
     mov edx,OFFSET str4          ;product number
     call WriteString		; display prompt
	call ReadInt		; read int from user
	add  ecx,eax		; store in array
     mov esi, eax
	   
     mov edx,OFFSET str3       ;product amount
     call WriteString		; display prompt
	call ReadInt		; read int from user
     cmp esi, 1
     je B2
     cmp esi, 2
     je B3
     cmp esi, 3
     je B4
     cmp esi, 4
     je B5
     cmp esi, 5
     je B6
     




     B6: add ecx, 12
     jmp B2
     B5: add ecx, 9
     jmp B2
     B4: add ecx, 6
     jmp B2
     B3: add ecx, 3
     B2:
     
     mov  [edi+ecx],eax		; store in array
     
	
    
     call Crlf
	jmp L1

	call Crlf

; Redisplay the integers

;	mov edx,OFFSET sales1		; "Redisplaying..."
;	call WriteString
;	mov ecx,COUNT
;	mov esi,OFFSET salesArray

 ;    mov edx,OFFSET str2		; "Redisplaying..."
;	call WriteString
;	mov ebx,COUNT
;	mov edi,OFFSET productsArray

B1:
call Crlf
mov edx,OFFSET sales5		; "Redisplaying..."
call WriteString
call Crlf
mov edx,OFFSET sales1		; "Redisplaying..."
call WriteString
mov edx,OFFSET space		; "Redisplaying..."
call WriteString

mov esi, 0

mov ebx, 256
mov ecx, 5
L2:	

     mov eax,[edi]		; get integer from array
     sub edx, edx
     div ebx
	call WriteInt		; display it
     add esi, eax
	mov edx,OFFSET space		; "Redisplaying..."
     call WriteString
	add  edi,TYPE productsArray

     

	loop L2
     mov edx,OFFSET space		; "Redisplaying..."
     call WriteString
     mov eax, esi
     call WriteInt
     call Crlf


mov edx,OFFSET sales2		; "Redisplaying..."
call WriteString
mov edx,OFFSET space		; "Redisplaying..."
call WriteString

mov esi, 0
mov ebx, 256
mov ecx, 5

L3:	

     mov eax,[edi]		; get integer from array
     sub edx, edx
     div ebx
	call WriteInt		; display it
     add esi, eax
	mov edx,OFFSET space		; "Redisplaying..."
     call WriteString
	add  edi,TYPE productsArray

    

	loop L3
      mov edx,OFFSET space		; "Redisplaying..."
     call WriteString
     mov eax, esi
     call WriteInt
     call Crlf

mov edx,OFFSET sales3		; "Redisplaying..."
call WriteString
mov edx,OFFSET space		; "Redisplaying..."
call WriteString

mov esi, 0
mov ebx, 256
mov ecx, 5
L4:	

     mov eax,[edi]		; get integer from array
     sub edx, edx
     div ebx
	call WriteInt		; display it
     add esi, eax
	mov edx,OFFSET space		; "Redisplaying..."
     call WriteString
	add  edi,TYPE productsArray

 

	loop L4
      mov edx,OFFSET space		; "Redisplaying..."
     call WriteString
     mov eax, esi
     call WriteInt
     call Crlf

mov edx,OFFSET sales4		; "Redisplaying..."
call WriteString
mov edx,OFFSET space		; "Redisplaying..."
call WriteString

mov esi, 0
mov ebx, 256
mov ecx, 5
L5:	

     mov eax,[edi]		; get integer from array
     sub edx, edx
     div ebx
	call WriteInt		; display it
     add esi, eax
	mov edx,OFFSET space		; "Redisplaying..."
     call WriteString
	add  edi,TYPE productsArray

    
	loop L5
      mov edx,OFFSET space		; "Redisplaying..."
     call WriteString
     mov eax, esi
     call WriteInt
     call Crlf
     call Crlf


	exit
main ENDP
END main