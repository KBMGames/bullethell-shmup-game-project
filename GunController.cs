using System.Collections;
using UnityEngine;

public class GunController : MonoBehaviour {

	public bool isFiring;

	public BulletController bullet;

	public float timeBetweenShots;
	private float shotCounter;

	public Transform firePoint;
	public Transform firePoint2;
	public Transform firePoint3;
	public Transform firePoint4;
	public Transform firePoint5;
	public Transform firePoint6;
	public Transform firePoint7;
	public Transform firePoint8;
	public Transform firePoint9;
	public Transform firePoint10;
	public Transform firePoint11;
	public Transform firePoint12;
	public Transform firePoint13;
	public Transform firePoint14;
	public Transform firePoint15;
	public Transform firePoint16;
	public Transform firePoint17;
	public Transform firePoint18;
	public Transform firePoint19;
	public Transform firePoint20;
	public Transform firePoint21;
	public Transform firePoint22;
	public Transform firePoint23;
	public Transform firePoint24;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (isFiring) {
		
			shotCounter -= Time.deltaTime;
			if (shotCounter <= 0) {
			
				shotCounter = timeBetweenShots;


				BulletController newBullet = Instantiate (bullet, firePoint.position, firePoint.rotation)as BulletController;
				BulletController newBullet2 = Instantiate (bullet, firePoint2.position, firePoint2.rotation)as BulletController;
				BulletController newBullet3 = Instantiate (bullet, firePoint3.position, firePoint3.rotation)as BulletController;
				BulletController newBullet4 = Instantiate (bullet, firePoint4.position, firePoint4.rotation)as BulletController;
				BulletController newBullet5 = Instantiate (bullet, firePoint5.position, firePoint5.rotation)as BulletController;
				BulletController newBullet6 = Instantiate (bullet, firePoint6.position, firePoint6.rotation)as BulletController;
				BulletController newBullet7 = Instantiate (bullet, firePoint7.position, firePoint7.rotation)as BulletController;
				BulletController newBullet8 = Instantiate (bullet, firePoint8.position, firePoint8.rotation)as BulletController;
				BulletController newBullet9 = Instantiate (bullet, firePoint9.position, firePoint9.rotation)as BulletController;
				BulletController newBullet1 = Instantiate (bullet, firePoint10.position, firePoint10.rotation)as BulletController;
				BulletController newBullet11 = Instantiate (bullet, firePoint11.position, firePoint11.rotation)as BulletController;
				BulletController newBullet12 = Instantiate (bullet, firePoint12.position, firePoint12.rotation)as BulletController;
				BulletController newBullet13 = Instantiate (bullet, firePoint13.position, firePoint13.rotation)as BulletController;
				BulletController newBullet14 = Instantiate (bullet, firePoint14.position, firePoint14.rotation)as BulletController;
				BulletController newBullet15 = Instantiate (bullet, firePoint15.position, firePoint15.rotation)as BulletController;
				BulletController newBullet16 = Instantiate (bullet, firePoint16.position, firePoint16.rotation)as BulletController;
				BulletController newBullet17 = Instantiate (bullet, firePoint17.position, firePoint17.rotation)as BulletController;
				BulletController newBullet18 = Instantiate (bullet, firePoint18.position, firePoint18.rotation)as BulletController;
				BulletController newBullet19 = Instantiate (bullet, firePoint19.position, firePoint19.rotation)as BulletController;
				BulletController newBullet20 = Instantiate (bullet, firePoint20.position, firePoint20.rotation)as BulletController;
				BulletController newBullet21 = Instantiate (bullet, firePoint21.position, firePoint21.rotation)as BulletController;
				BulletController newBullet22 = Instantiate (bullet, firePoint22.position, firePoint22.rotation)as BulletController;
				BulletController newBullet23 = Instantiate (bullet, firePoint23.position, firePoint23.rotation)as BulletController;
				BulletController newBullet24 = Instantiate (bullet, firePoint24.position, firePoint24.rotation)as BulletController;



			
			}
		
		} else {
				
			shotCounter = 0;

		}

	}
}
