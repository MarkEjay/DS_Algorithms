
public class Recursion {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		System.out.print(itFac(5));
	}

	public static int fac(int n) {
	//	int ret=0;
		
		if(n<2) {
			return n;
		}
		
		return n * fac(n-1);
	}
	
	public static int itFac(int n) {
		int res=1;
		if(n<2) {
			return n;
		}
		for(int i = 2; i<=n; i++) {
			res *=i;
		}
		return res;
	}
}
