using Learun.Util;
using System.Collections.Generic;

namespace Learun.Application.TwoDevelopment.DM_APPManage
{
	public interface DM_UserIBLL
	{
		IEnumerable<dm_userEntity> GetList(string queryJson);

		IEnumerable<dm_userEntity> GetPageList(Pagination pagination, string queryJson);

		dm_userEntity GetEntity(int keyValue);

		dm_userEntity GetEntityByPhone(string phone, string appid);

		dm_userEntity GetEntityByCache(int id);

		void DeleteEntity(int keyValue);

		void SaveEntity(int keyValue, dm_userEntity entity);

		dm_userEntity Login(dm_userEntity entity);

		dm_userEntity Register(dm_userEntity dm_UserEntity, string VerifiCode, string appid);

		string EncodeInviteCode(int? id);

		int? DecodeInviteCode(string InviteCode);

		dynamic SignIn(int userid);
        #region ��ȡ�ƹ�ͼƬ
        List<string> GetShareImage(int user_id, string appid);
        #endregion

        #region ��ȡ�û�����
        IEnumerable<dm_userEntity> GetParentUser(int user_id);
        IEnumerable<dm_userEntity> GetChildUser(int user_id);

        dm_userEntity GetUserByPartnersID(int partnersid);
        #endregion
    }
}
