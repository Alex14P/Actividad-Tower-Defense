using UnityEngine;

public class Bullet : MonoBehaviour {

	private Transform target;

	public float speed = 70f;

	public int damage = 50;

	public float explosionRadius = 0f;
	public GameObject impactEffect;
	
	public void Seek (Transform _target)
	{
		target = _target;
	}

	// Update is called once per frame
	void Update () {
	//Destruir bala al chocar
		if (target == null)
		{
			Destroy(gameObject);
			return;
		}

		Vector3 dir = target.position - transform.position;
		float distanceThisFrame = speed * Time.deltaTime;
	//Check bala a enemigo
		if (dir.magnitude <= distanceThisFrame)
		{
			HitTarget();
			return;
		}

		transform.Translate(dir.normalized * distanceThisFrame, Space.World);
		transform.LookAt(target);

	}
	
	//Logica de daño de bala
	void HitTarget ()
	{
		GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
		Destroy(effectIns, 5f);

		if (explosionRadius > 0f)
		{
			Explode();
		} else
		{
			Damage(target);
		}

		Destroy(gameObject);
	}

	//Destruccion
	void Explode ()
	{
		Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
		foreach (Collider collider in colliders)
		{
			if (collider.tag == "Enemy")
			{
				Damage(collider.transform);
			}
		}
	}

	//Daño acumulado a enemigo
	void Damage (Transform enemy)
	{
		Enemy e = enemy.GetComponent<Enemy>();

		if (e != null)
		{
			e.TakeDamage(damage);
		}
	}

	void OnDrawGizmosSelected ()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, explosionRadius);
	}
}
