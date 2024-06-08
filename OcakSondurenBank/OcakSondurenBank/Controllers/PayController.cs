using OcakSondurenBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OcakSondurenBank.Controllers
{
    public class PayController : ApiController
    {
        OcakSondurenBankDBEntities db = new OcakSondurenBankDBEntities();
        //https://localhost:44394/API/Pay?kartno=1111222233334444&sonkullanmaAy=12&sonkullanmayil=28&CVV=123&fiyat=45.4
        public string Get(string kartno, string sonkullanmaAy, string sonkullanmayil, string CVV, decimal fiyat)
        {
            Hesaplar h = db.Hesaplars.FirstOrDefault(x => x.KartNo == kartno);

            if (h != null)
            {
                if (sonkullanmayil == h.SonKullanmaYil && sonkullanmaAy == h.SonKullanmaAy)
                {
                    DateTime kart = Convert.ToDateTime(DateTime.Now.Day + "-" + sonkullanmaAy + "-" + sonkullanmayil);

                    if (kart >= DateTime.Now)
                    {
                        if (CVV == h.CVV)
                        {
                            if (Convert.ToBoolean(h.Aktif))
                            {
                                if (h.Bakiye > fiyat)
                                {
                                    try
                                    {
                                        int id = db.Hesaplars.FirstOrDefault(x => x.KartNo == kartno).ID;
                                        Hesaplar hh = db.Hesaplars.Find(id);
                                        hh.Bakiye -= fiyat;
                                        db.SaveChanges();
                                        return "201";
                                    }
                                    catch
                                    {
                                        return "301";
                                    }
                                }
                                else
                                {
                                    return "401";
                                }
                            }
                            else
                            {
                                return "501";
                            }
                        }
                        else
                        {
                            return "601";
                        }
                    }
                    else
                    {
                        return "701";
                    }
                }
                else
                {
                    return "801";
                }
            }
            else
            {
                return "901";
            }
        }
    }
}
