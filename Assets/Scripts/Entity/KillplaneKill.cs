using UnityEngine;
using Photon.Pun;

public class KillplaneKill : MonoBehaviourPun {

    [SerializeField] private float killTime = 0f;
    private float timer = 0;
    public bool killplaneDeath = false;

    public void Update() {
        if (transform.position.y >= GameManager.Instance.GetLevelMinY())
            return;

        if ((timer += Time.deltaTime) < killTime)
            return;

        if (!photonView) {
            killplaneDeath = true;
            Destroy(gameObject);
            return;
        }
        if (photonView.IsMine) {
            killplaneDeath = true;
            PhotonNetwork.Destroy(photonView);
            return;
        }
    }
}
