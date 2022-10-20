import java.util.Scanner;

abstract class shape{
	private shape next; //자료형이 shape 클래스인 next 레퍼런스변수
	public shape() {
		next=null;
	}
	
	public void setnext(shape obj) {
		next=obj; //next 명령 실행 시, 다음 도형의 노드형태가 next에 대입되어 가르키게된다. next는 화살표라고 생각하자
		
	}
	public shape getnext() {
		return next;
	}
	public abstract void draw();
	
}

class Line extends shape{
	public Line(){
		super();
	}
	public void draw() {
		System.out.println("--Line--");
	}
}

class Rect extends shape{
	public Rect(){
		super();
	}
	public void draw() {
		System.out.println("--Rect--");
	}
	
}

class Circle extends shape{
	public Circle(){
		super();
	}
	public void draw() {
		System.out.println("--Circle--");
	}
}

class GPeditor{
	Scanner scan = new Scanner(System.in);
	shape head, tail; // shape 자료형 (next화살표를 가지는)인 head와 tail 생성(포인터느낌으로 사용) -> 
	int nodesize=0; // 그래픽에디터에서 생성한 도형 갯수 카운트, 기본값 = 0
	int choice; // 메뉴판에서 선택할 시 숫자 
	int shape_choice;
	
	public GPeditor() {// 생성자 호출 시...
		tail=null;//꼬리를 null로 둠 (최초 작업)
		run(); // GPeditor에 내부 멤버 필드인 run 작동(메뉴판 작동이라고 이해할 것)
	}
	public void run() {
		System.out.println("===그래픽 에디터를 실행합니다===");
		
		while(true) {
			System.out.println("삽입(1), 삭제(2), 모두 보기(3), 종료(4)");
			
			if(choice==1) {//도형 삽입 시
				System.out.println("Line(1), Rect(2), Circle(3)");
				shape_choice = scan.nextInt();
				if(shape_choice >=1 && shape_choice <=3) {
					add(shape_choice);
				}
			}
		}
		
		
	}
	
	public void add(int shape_choice) {
		
	}
	
	public void addNode(shape obj) {
		if(head==null) {//여기서 head와 tail은 GPeditor에서 가져옴(의문점 : 가져올수있는가? 클래스 내부라서 가져올수있나?)
			shape node =obj;//매개변수로 받은 obj
			head= node; //
			nodesize++;//node사이즈의 필드를 ++
			tail=node;//
			
			//해당 과정은 처음 노드를 생성할 때, 지역 객체 node에 매개변수 obj를 통해 넘겨받고 head와 tail을 초기화하는 작업, nodesize는 해당 함수가 발동될때마다 증가 시켜야함
		}
		else {
			shape node=obj;//노드 생성
			tail.setnext(node);// 현재 만든 객체 참조하라는 명령(next)
			tail=node;
			nodesize++;
		}
	}
	
	public void delete(int choice) {
		int index=choice-1; //삭제할 도형의 위치를 지정 --> 왜 -1 인가?(choice=1부터 시작이므로!) 
		shape node = head; // head는 시작부분 !
		if(index==0) {//처음 객체를 지울 때
			head=node.getnext(); //
		}
		for(int i=0;i<index-1;i++) {//삭제하고 싶은 부분의 전 번지까지 이동한다
			node=node.getnext();//만약 3번째 번지를 지우고싶다면(choice=3), index=2이고 해당 구문은 한번 작동할것이다
			//node
			
		}
		//전 번지까지 이동완료한 head(=node)에서 setnext로 설정한다.(getnext를 두번 가게하여 그 노드로 연결하여 중간노드를 생략하는 기법)
		node.setnext(node.getnext().getnext());//
		
	}
	
	public void show() {
		shape node=head;
		while(node!=null) {
			node.draw();//head를 draw
			node=node.getnext();//다음 노드 next를 대입하여 옮기기->
			
		}
	}
	
	public void exit() {
		System.out.println("== 해당 프로그램을 종료합니다==");
		System.exit(0);
	}
}


public class LinkedList81 {
	public static void Main(String[] args) {
		new GPeditor();
	}
}
